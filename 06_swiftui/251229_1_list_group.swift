import SwiftUI

struct ContentView: View {
    let shikoku = ["도쿠시마현", "카가와현", "아이치현", "고치현"]
    let kyusyu = ["후쿠오카현", "사가현", "나가사키현", "쿠마모토현", "오오이다현", "미야사키현", "카고시마현"]
    var body: some View {
        List {
            Section(
                header: Text("시코쿠").font(.largeTitle).padding(.top),
                footer: Text("최고높이는 이시즈치산의 1,982m")
            ) {
                ForEach(shikoku, id: \.self) { item in
                    Text(item)
                }
            }
            Section(
                header: Text("큐슈").font(.largeTitle).padding(.top),
                footer: Text("최고높이는 미야노우라다케의 1,936m")
            ) {
                ForEach(kyusyu, id: \.self) { item in
                    Text(item)
                }
            }
        }
        // .listStyle(InsetListStyle())
        // .listStyle(InsetGroupedListStyle())
        // .listStyle(GroupedListStyle())
        .listStyle(SidebarListStyle())
        // .listStyle(PlainListStyle())
    }
}