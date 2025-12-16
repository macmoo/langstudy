import SwiftUI

let metro = ["긴자선", "마루노우치선", "히비야선", "도자이선", "치요다선", "한조몬선", "남보쿠선", "부도심선"]

struct ContentView: View {
    var body: some View {
        // -------------------------
         List(0..<5) { item in
             HStack {
                 Text(String(item))
                 Text("Hello, world!")
             }
         }
        // -------------------------
         List ( 0 ..< 8 ) { item in
             HStack{
                 Text(String(item))
                 Text(metro[item])
             }
         }
        // -------------------------
        // List(0..<metro.count, id: \.self) { item in
        List(metro.indices, id: \.self) { item in
            HStack {
                Text(String(item))
                Text(metro[item])
            }
        }
        // -------------------------
    }
}
