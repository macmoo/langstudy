//
//  ContentView.swift
//  test_250720
//
//  Created by kaku on 2025/07/20.
//
// Mutiple Control

import SwiftUI

struct ContentView: View {
    var body: some View {
        VStack {
            HStack{
                Text("First")
                    .font(.largeTitle)
                    .border(Color.red, width:2)
                    .padding(10)
                Text("Second")
                    .font(.largeTitle)
                    .border(Color.red, width:2)
                    .padding(10)
            }
            .frame(width:300, height:100)
            .border(Color.red, width:2)
            .padding(10)
            
            HStack{
                Text("Thrid")
                    .font(.largeTitle)
                    .border(Color.red, width:2)
                    .padding(10)
                Text("Fourth")
                    .font(.largeTitle)
                    .border(Color.red, width:2)
                    .padding(10)
            }
            .frame(width:300, height: 100)
            .border(Color.red, width:2)
            .padding(10)
        }
        .padding(10)
        .border(Color.blue, width:2)
    }
}

#Preview {
    ContentView()
}
