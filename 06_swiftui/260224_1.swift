import SwiftUI

struct webData: Identifiable {
    var id = UUID()  // Identifiable프로토콜에서 필수
    var name: String
    var url: String
    var favicon: String
}

struct ContentView: View {

    let webList = [
        webData(name: "그레이트곽", url: "https://github.com/macmoo/langstudy", favicon: "icon_1"),
        webData(name: "도쿄국립박물관", url: "https://www.tnm.jp/", favicon: "icon_2"),
        webData(name: "도쿄현대미술관", url: "https://www.mot-art-museum.jp/",favicon: "icon_3"),
        webData(name: "카와사키수족관", url: "htps://kawa-sui.com/", favicon: "icon_4"),
    ]

    var body: some View {
        NavigationView {
            List(webList) { item in
                Image(item.favicon).resizable().frame(width: 40, height: 40)
                // Link(item.name, destination: URL(string: item.url)!)
                
                // UIApplication.shared.canOpenURL(url)로 url체크
                // 옵셔날 바인딩041
                if let url = URL(string: item.url), UIApplication.shared.canOpenURL(url){
                    Link(item.name, destination: url)
                } else {
                    Text(item.name).foregroundColor(.gray) + Text(" URL에러").foregroundColor(.red).italic()
                }
            }.navigationTitle("Web리스트")
        }.navigationViewStyle(.stack)
    }
    // Web페이지를 여는 링크는
    // Link(_ title: Stirng, url: URL)형식으로 작성
    // 1번 인수는 _ 이므로 인수명은 불필요.(외부인수명)
    // URL(string: item.url)!  : URL(string:)은 nil일 가능성이 있는 옵셔날밸류이므로 !로 강제언랩
}