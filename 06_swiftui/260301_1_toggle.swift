//
//  ContentView.swift
//  test_ios_260228_1
//
//  Created by kaku on 2026/03/01.
//

import SwiftUI

struct ContentView: View {

    @State var iLike = true
    @State var isShow = true
    @State var isYaruki = true
    @State var isAuto = true
    @State var isFast = true

    var body: some View {
        // ------------------------------------
        // 토글 텍스트
        VStack {
            // 토글스위치로 iLike값이 true/false로 전환된다.
            Toggle(isOn: $iLike) {
                Text("Like or Not").font(.largeTitle)
            }
            .fixedSize()
            .padding(20)

            if iLike {
                Image(systemName: "heart.fill")
                    .font(.system(size: 40))
                    .foregroundColor(.red)
            } else {
                Image(systemName: "heart.slash")
                    .font(.system(size: 40))
                    .foregroundColor(.gray)
            }
        }
        // ------------------------------------
        // 토글 버튼
        VStack {
            Toggle(isOn: $isShow) {
                Label(
                    isShow ? "끄기" : "켜기",
                    systemImage: isShow ? "eye.slash" : "eye"
                )
                .frame(width: 150)

            }
            .toggleStyle(.button)
            .tint(isShow ? .red : .indigo)
            .clipShape(Capsule())
            .animation(.easeInOut(duration: 0.2), value: isShow)
            // 이미지
            Image("eigakan")
                .resizable()
                .aspectRatio(contentMode: .fit)
                .frame(width: 300)
                .opacity(isShow ? 1.0 : 0.0)
                .animation(.easeInOut(duration: 1.0), value: isShow)
        }
        // ------------------------------------
        VStack(alignment: .leading) {
            Toggle("야루키모드", isOn: $isYaruki).tint(.yellow)
            Toggle("자동설정", isOn: $isAuto).tint(.red)
        }
        .frame(width: 200)
        // ------------------------------------
        // Toggle없이 토글
        HStack {
            Button(action: { withAnimation { isFast.toggle() } }) {
                // 버튼명
                Text(isFast ? "RUN" : "STOP")
                    .font(.title)
                    .foregroundColor(isFast ? .red : .black)
                    .padding(.trailing)
                    .frame(width: 100)
                // 이미지변경
                Image(systemName: isFast ? "hare" : "tortoise")
                    .foregroundColor(isFast ? .blue : .green)
                    .rotationEffect(.degrees(isFast ? 0 : 180))
                    .scaleEffect(3)  // 3배사이즈
                    .frame(width: 100)
            }
            .frame(width: 240, height: 70)
        }
        // ------------------------------------
        // SF 심볼즈
        HStack {
            Image(systemName: "sum.max")
            Image(systemName: "cloud.rain")
            Image(systemName: "camera")
            Image(systemName: "message")
            Image(systemName: "a.circle")
            Image(systemName: "calendar")
            Image(systemName: "snowflake")
            Image(systemName: "star.fill")
                .frame(width: 34, height: 34)
                .foregroundColor(Color.yellow)
                .background(Color.green)
                .clipShape(Circle())
        }
        .imageScale(.large)
        // ------------------------------------
    }
}

#Preview {
    ContentView()
}
