import SwiftUI

let colors: [Color] = [.red, .blue, .green, .orange, .yellow]

struct ContentView: View {
    var body: some View {
        VStack {
            ForEach(colors.indices, id: \.self) { index in
                Rectangle()
                    .frame(width:150, height: 30)
                    .foregroundColor(colors[index])
            }
        }
    }
}
