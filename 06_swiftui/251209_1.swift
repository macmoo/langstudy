import SwiftUI

struct ContentView: View {
    var body: some View {
        // ----------------------------
        // Circle()
        // Ellipse()
        // Rectangle()
        // RoundedRectangle(cornerRadius: 50)
        Capsule()
           .foregroundColor(.blue)
           .frame(width: 200, height: 300)
        // ----------------------------
        Circle()
            .fill(Color.wakakusa)
            .foregroundColor(Color("Wakakusa"))
            .foregroundColor(.wakakusa)
            .padding(50)
        // ----------------------------
        Ellipse()
            .foregroundColor(.orange)
            .frame(width: 200, height: 400)
            .rotationEffect(.degrees(45)) // 회전
            .border(Color.black, width: 1)
            .clipped()
        // ----------------------------
        ZStack {
            Ellipse()
                .stroke(lineWidth: 4) // 선으로 그림
                .foregroundColor(.pink)
                .frame(width: 100, height: 300)
            Ellipse()
                .stroke(lineWidth: 4)
                .foregroundColor(.purple)
                .frame(width: 100, height: 300)
                .rotationEffect(.degrees(30), anchor: .bottom)
            Ellipse()
                .stroke(lineWidth: 4)
                .foregroundColor(.green)
                .frame(width: 100, height: 300)
                .rotationEffect(.degrees(-30), anchor: .bottom)
        }
        // ----------------------------
        ZStack {
            Circle()
                .foregroundColor(.green)
                .frame(width: 100, height: 100)
                .position(x:120, y:150)
            Rectangle()
                .foregroundColor(.orange)
                .frame(width: 100, height: 100)
                .position(x:300, y:350)
        }
        .border(Color.black, width: 1)
        .edgesIgnoringSafeArea(.all) // safe area를 무시
    }
}
