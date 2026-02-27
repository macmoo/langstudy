//
//  ContentView.swift
//  test_ios_260227_2
//
//  Created by kaku on 2026/02/28.
//

import SwiftUI

struct ContentView: View {

    let janken = ["바위", "가위", "보"]
    @State var te = ""

    var body: some View {
        VStack {
            Button("가위 바위 보") {
                te = janken.randomElement()!
            }
            .foregroundColor(.white)
            .background(
                Capsule()
                    .foregroundColor(.blue)
                    .frame(width: 120, height: 40)
            )
            Text(te).font(.largeTitle).padding()
        }
    }
}

#Preview {
    ContentView()
}
