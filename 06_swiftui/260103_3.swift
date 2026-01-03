import SwiftUI

struct ContentView: View {
    var body: some View {
        NavigationView {
            NavigationLink(destination: detailView()) {
                HStack(alignment: .bottom, spacing: 10) {
                    Image("IMG_6460")
                        .resizable()
                        .aspectRatio(contentMode: .fit)
                        .frame(width: 100)
                    Text("타카토리산")
                }
            }
            .navigationTitle("인기SPOT")
        }
        .navigationViewStyle(.stack)
    }
}

@ViewBuilder
// @ViewBuilder를 추가해서 유저정의함수를 만들수 있다.
// func 함수명() -> 반환값의 형
func detailView() -> some View {
    VStack {
        Text("하이킹코스").font(.title2)
        Image("IMG_6460")
            .resizable()
            .aspectRatio(contentMode: .fit)
        Text("요코스카현")
    }
    .padding()
}

#Preview {
    ContentView()
    detailView()
}
