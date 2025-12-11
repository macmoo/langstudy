import SwiftUI

struct ContentView: View {
    var body: some View {
        NavigationView {
            List {
                Text("콘텐츠1")
                Text("콘텐츠2")
                Photo1().frame(height: 150)
                Text("콘텐츠3")
                Text("콘텐츠4")
                Photo2().frame(height: 150)
                Text("콘텐츠5")
                Text("콘텐츠6")
            }
            .navigationTitle("タイトル")
        }
    }
}

struct Photo1: View {
    var body: some View {
        HStack {
            Image("IMG_4116")
                .resizable()
                .aspectRatio(contentMode: .fill)
            Text("nanae")
                .padding(.horizontal)
        }
    }
}

struct Photo2: View {
    var body: some View {
        HStack {
            Image("IMG_4291")
                .resizable()
                .aspectRatio(contentMode: .fit)
            Text("nanae2")
                .padding(.horizontal)
        }
    }
}
