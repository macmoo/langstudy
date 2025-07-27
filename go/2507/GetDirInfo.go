package main

//
// OMDb	https://www.omdbapi.com/apikey.aspx
// TMDb	https://www.themoviedb.org/settings/api
// KOBIS	https://www.kobis.or.kr/kobisopenapi/homepg/main/main.do
// RapidAPI (IMDb, Watchmode 등)	https://rapidapi.com/hub
//
//
//
// KEY : 28bce2e7900ec4108c49b6cf0ec770e4
// ACCESS TOKEN :
// eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIyOGJjZTJlNzkwMGVjNDEwOGM0OWI2Y2YwZWM3NzBlNCIsIm5iZiI6MTc1MzU1MTM4MC4zMTUsInN1YiI6IjY4ODUxMjE0NDlmOWE0ZTZlZjcyZWFhMiIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.F2jdN1iS98MT_OHjUXOWcH4A96nynCYCvHAj2YeFR9A
//
//
//
// file
// https://qiita.com/yNavS4Ki/items/947c981b4b98893c9599
//

import (
	"encoding/json"
	"flag"
	"fmt"
	"net/http"
	"net/url"
	"os"
	"path/filepath"
	"regexp"
	"strings"
	"time"
)

var (
	dir_path = flag.String("p", "", "<dir path>")
)

type SearchResult struct {
	Results []struct {
		ID int `json:"id"`
	} `json:"results"`
}

type Credits struct {
	Crew []struct {
		Job  string `json:"job"`
		Name string `json:"name"`
	} `json:"crew"`
}

// --url 'https://api.themoviedb.org/3/search/movie?query=Parasite&primary_release_year=2019&page=1' \
// --url https://api.themoviedb.org/3/movie/496243/credits \
func getDirectorTMDb(title, year string) (string, bool) {
	// apiKey := "YOUR_API_KEY"
	apiKey := "28bce2e7900ec4108c49b6cf0ec770e4"
	baseURL := "https://api.themoviedb.org/3"

	// Step 1: Search movie
	// url := "https://api.themoviedb.org/3/search/movie?include_adult=false&language=en-US&page=1"

	searchURL := fmt.Sprintf("%s/search/movie?api_key=%s&query=%s&primary_release_year=%s", baseURL, apiKey, url.QueryEscape(title), url.QueryEscape(year))
	resp, _ := http.Get(searchURL)
	defer resp.Body.Close()

	// fmt.Println("response:", resp.Body)
	var result SearchResult
	json.NewDecoder(resp.Body).Decode(&result)
	if len(result.Results) == 0 {
		return "영화 찾을 수 없음", false
	}
	movieID := result.Results[0].ID

	// Step 2: Get credits
	creditsURL := fmt.Sprintf("%s/movie/%d/credits?api_key=%s", baseURL, movieID, apiKey)
	resp2, _ := http.Get(creditsURL)
	defer resp2.Body.Close()

	var credits Credits
	json.NewDecoder(resp2.Body).Decode(&credits)

	// fmt.Println("Credits : ", credits)
	for _, crew := range credits.Crew {
		if crew.Job == "Director" {
			return crew.Name, true
		}
	}
	return "감독 정보 없음", false
}

// -----------------------------------------------------
func extractYears(text string) []string {
	// 연도는 일반적으로 1000~2999 범위에 있음
	re := regexp.MustCompile(`\b(1[0-9]{3}|2[0-9]{3})\b`)
	return re.FindAllString(text, -1)
}

// f_list
// -----------------------------------------------------

// -----------------------------------------------------
func main() {

	flag.Parse()

	f_list, e := os.ReadDir(*dir_path)
	if e != nil {
		fmt.Println("Error directory files. =>", e)
		return
	}
	title_year := []string{}
	for _, f := range f_list {
		years := extractYears(f.Name())
		if len(years) <= 0 {
			continue
		}
		f_name_cut, _, _ := strings.Cut(f.Name(), years[0])
		mov_title := strings.ReplaceAll(f_name_cut, ".", " ")
		mov_title = strings.TrimSuffix(mov_title, " ")

		title_year = append(title_year, strings.Join([]string{mov_title, years[0]}, "-"))
	}
	title_year = removeDuplicates(title_year)

	result_list := []string{}
	for _, elem := range title_year {

		splited := strings.Split(elem, "-")
		// call API
		director, found := getDirectorTMDb(splited[0], splited[1])
		if !found {
			result_list = append(result_list, strings.Join([]string{splited[0], splited[1], "-----"}, "\t"))
			continue
		}
		result_list = append(result_list, strings.Join([]string{splited[0], splited[1], director}, "\t"))
	}

	// fmt.Println(result_list)
	filenm_post := time.Now().Format("20060102_150405")
	out_file, err_file := os.Create(filepath.Join(*dir_path, "__OUT_"+filenm_post+".txt"))
	if err_file != nil {
		fmt.Println("Error file create.", err_file)
	}
	defer out_file.Close()
	// fmt.Println(out_file)
	for _, e := range result_list {
		out_file.WriteString(e + "\n")
	}
}

func removeDuplicates(input []string) []string {
	seen := make(map[string]bool)
	result := []string{}

	for _, val := range input {
		if !seen[val] {
			seen[val] = true
			result = append(result, val)
		}
	}
	return result
}
