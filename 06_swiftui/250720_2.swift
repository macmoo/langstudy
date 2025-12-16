//
//  ContentView.swift
//  test_250720
//
//  Created by kaku on 2025/07/20.
//
// ForEach
// Viewの{}中にはコントロールの文以外は書けない。

import SwiftUI

struct ContentView: View {
    let data = [Text("Hello"), Text("Welcome"), Text("Bye")]
    let colors: [Color] = [.red,.green, .blue, .yellow, .orange, .pink]
    var body: some View {
        // -------------------------
        // ForEach(開始値..<終了値){ 引数 in 部品の構成 }
        ForEach(0..<5){index in
            Text("No, \(index).")
                .font(.largeTitle)
                .padding(10)
         }
        // -------------------------
        ForEach(0..<data.count){index in
            self.data[index]
                .font(.largeTitle)
                .frame(width:200,height:50)
                .border(Color.blue, width:2.0)
        }
        // -------------------------
        // ForEach(配列など, id: \.self){ 引数 in ... }
        ForEach(colors, id: \.self){ color in
            Text(color.description)
                .font(.largeTitle)
                .frame(width:200, height:70)
                .background(color)
        }
        // -------------------------
    }
}

#Preview {
    ContentView()
}
