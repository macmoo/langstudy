//
//  ContentView.swift
//  test_ios_260226_1
//
//  Created by kaku on 2026/02/26.
//

import SwiftUI

// 버튼을 만드는 간단한 방법
//
// Button("버튼명") {
//     실행할 액션
// }
struct ContentView: View{
    
    @State var msg = "탱큐"
    
    var body: some View{
        VStack{
            Button("Tap"){
                msg = "감사감사"
            }
            .font(.headline)
            .foregroundColor(.white)
            .background(
                // 캡슐형 버튼 생성
                Capsule()
                    .foregroundColor(.green)
                    .frame(width: 80, height: 30)
            )
            // 결과
            Text(msg).padding()
        }
    }
}

#Preview {
    ContentView()
}
