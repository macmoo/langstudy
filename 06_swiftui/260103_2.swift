import SwiftUI

struct ContentView: View {
    var body: some View {
        NavigationView {
            NavigationLink(destination: SubView()) {
                Label("Go SubView", systemImage: "message")
            }
            .navigationTitle("Home")
        }
        .navigationViewStyle(.stack)
    }
}

struct SubView: View {
    var body: some View {
        Text("SubView").font(.largeTitle)
    }
}

#Preview {
    ContentView()
}
