//
//  ContentView.swift
//  test_ios_260226_1
//
//  Created by kaku on 2026/02/26.
//

import SwiftUI

//struct ContentView: View {
//    var body: some View {
//        // ------------------------------
//        // #1
//        //　Button(action: {}) {
//        //　　　　　Text("Button")
//        //　}
//        // ------------------------------
//        // #2
//        Button(action: {
//            let num = Int.random(in: 0...1000)
//            print(num)  // debug preview
//        }) {
//            Text("Random Button")
//                .font(.largeTitle)
//                .frame(width: 280, height: 60, alignment: .center)
//                .foregroundColor(Color.pink)
//                .cornerRadius(15, antialiased: true)
//        }
//       // ------------------------------
//    }
//}

struct ContentView: View {

    // 변수의 소유자가 self 즉, "struct ContentView"에서 만들어진
    // 인스턴스가 변경을 허용하지 않기 때문에 밑의 선언은 에러
    // var num: Int = 0
    
    // @State를 붙여 num이 변경가능한 변수가 된다.
    // 값의 변화를 감시해, 값이 변하면 View도 갱신된다.
    @State var num: Int = 0

    var body: some View {
        VStack {
            Button(action: {
                // 버튼을 누를때마다 실행하는 기능
                num = Int.random(in: 0...100)
            }) {
                Text("Random Button")
                    .font(.largeTitle)
                    .frame(width: 280, height: 60, alignment: .center)
                    .foregroundColor(Color.white)
                    .background(Color.pink)
                    .cornerRadius(15, antialiased: true)
            }
            Text("\(num)")
                .font(.largeTitle)
                .padding()
        }
    }
}

#Preview {
    ContentView()
}
