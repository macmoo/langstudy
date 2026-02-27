//
//  ContentView.swift
//  test_ios_260226_2
//
//  Created by kaku on 2026/02/26.
//

import SwiftUI

struct ContentView: View {
    var body: some View {
        Button(action: {
            // 버튼을 누를때마다 실행하는 기능
            print("Hello World!")
        }){
            Text("Tap")
                .font(.largeTitle)
        }
    }
}

#Preview {
    ContentView()
}
