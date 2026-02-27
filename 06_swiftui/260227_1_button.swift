//
//  ContentView.swift
//  test_ios_260227_1
//
//  Created by kaku on 2026/02/27.
//

import SwiftUI

struct ContentView: View {
    @State var num: Int = 0
    var body: some View {
        VStack {
            HStack {
                Text("\(num)")
                    .font(.system(size: 50))
                    .padding(.trailing)
                Button(
                    action: { num += 1 },
                    label: { Text("Tap").font(.largeTitle) })
            }
            Button(action: { num = 0 }) { Text("Zero").font(.largeTitle) }
        }
    }
}
#Preview {
    ContentView()
}
