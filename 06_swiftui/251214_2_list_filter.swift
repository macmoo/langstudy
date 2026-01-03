import SwiftUI

struct ContentView: View {
    let spots = [
        "도쿄도미술관", "국립신미술관", "국립근대미술관", "도쿄국립박물관", "에도도쿄박물관", "국립과학박물관",
        "신에노시마수족관", "가와사키수족관", "시나가와수족관",
    ]
    @State private var searchText = ""
    var body: some View {
        NavigationView {
            List {
                ForEach(searchResults, id: \.self) { name in
                    Text(name)
                }
            }
            .searchable(text: $searchText, prompt: "スポットの検索")
            .keyboardType(.default)
            .navigationTitle("人気のスポット")

        }
        var searchResults: [String] {
            if searchText.isEmpty {
                return spots
            } else {
                // filter()는 요소를 순서대로 추출, $0.contains(searchText)의 조건식을 평가하고
                // 결과가 true일 경우에만 추출
                // $0 순차적으로 추출하는 요소를 나타냄
                return spots.filter { $0.contains(searchText) }
            }
        }
    }
}