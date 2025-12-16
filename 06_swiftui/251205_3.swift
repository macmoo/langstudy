
import SwiftUI

struct ContentView: View {
    var body: some View {
        VStack {
            Image("IMG_4291")
                // 화면사이즈에 맞춰서 늘림
                .resizable(resizingMode: .stretch)
                // 종횡비를 맞춤 = .scaledToFit()
                .aspectRatio(contentMode: .fit)
                // 프레임 사이즈
                .frame(width: 350)
                .clipped(antialiased: true)
                .overlay(
                    Text("ヨボ")
                        .font(.title)
                        .fontWeight(.bold)
                        .foregroundColor(.white)
                        .offset(x: 0, y: 100)
                )
        }

        VStack {
            Image("IMG_4116")
                .resizable(resizingMode: .stretch)
                // 프레임에에 맞춤 = scaledToFill()
                .aspectRatio(contentMode: .fill)
                // 그림을 1.8배 확대
                // .scaleEffect(1.8)
                // 화상위치 조정
                // .offset(x: 70, y: -70)
                .frame(width: 300, height: 300)
                // 삐져나온 부분 삭제 (마지막에 실행)
                .clipped()
        }
    }
}