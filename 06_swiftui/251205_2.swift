import SwiftUI

struct ContentView: View {
    var body: some View {
        VStack {
            //            Spacer()
            VStack(alignment: .leading) {
                Text("지성의 자동차")
                    .font(.largeTitle)
                    .fontWeight(.black)
                    .padding([.leading, .bottom], 20.0)
                    .border(Color.red, width: 2)
                    .background(Color.yellow)
                Text("자전거 포 더 마인드")
                    .italic()
                    .offset(x: -10, y: 0)  // 표시를 왼쪽으로 10 당김
                    .border(Color.red, width: 2)

            }
            .padding(.top, 80)
            .border(Color.black, width: 3)

            Spacer().border(Color.green, width: 3)
            
            VStack(alignment: .trailing) {
                Text("코이노 하지마리")
                    .font(.largeTitle)
                    .fontWeight(.medium)
                    .padding(.vertical, 10.0)
                    .padding(.horizontal, 30)
                    .border(Color.blue, width: 3)
                Text("피티 이즈 어킨 투 러브")
                    .italic()
                    .offset(x: -10, y: 0)
                    .border(Color.blue, width: 2)
            }
            .padding(.top, 20)
            .border(Color.yellow, width: 3)
            Spacer()
                .border(Color.blue, width: 3)
        }

    }
}
