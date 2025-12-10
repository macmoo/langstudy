import SwiftUI

struct ContentView: View {
    var body: some View {

        // ----------------------------
        // Image("IMG_4291")
        //     .resizable()
        //     .aspectRatio(contentMode: .fill)
        //     .frame(width:300, height:300)
        //     .border(Color.red)
        // ----------------------------
        // Image("IMG_4291")
        //     .resizable()
        //     .aspectRatio(contentMode: .fill)
        //     .frame(width: 300, height: 300)
        //     // .clipShape(Circle())
        //     .clipShape(RoundedRectangle(cornerRadius: 50))
        //     .shadow(radius: 20)
        // ----------------------------
        // Image("IMG_4291")
        //     .resizable()
        //     .aspectRatio(contentMode: .fill)
        //     .frame(width: 300, height: 300)
        //     .clipped()
        //     .rotationEffect(.degrees(20), anchor: .center)
        //     .border(Color.red)
        // ----------------------------
        // Text("Hello World!")
        //     .font(.body)
        //     .frame(width: 150, height: 150)
        //     .border(Color.pink, width: 10)
        //     .cornerRadius(20)
        // ----------------------------
        // Text("Hello World")
        //     .font(.largeTitle)
        //     .padding(15)
        //     .foregroundColor(.white)
        //     .background(ShapeView())
        //     .cornerRadius(50)
        //     .frame(width: 150, height: 150)
        // ----------------------------
        // Text("春はあけぼの。やうやう白くなり行く、山ぎは少しあかりて、紫だちたる雲の細くたなびきたる。")
        //     .fontWeight(.light)
        //     .font(.title)
        //     .frame(width: 250)
        //     .rotation3DEffect(
        //         .degrees(45), axis: (x: 0, y: 1, z: 0)
        //     )
        // ----------------------------
        ZStack {
            Image("IMG_4291")
                .resizable()
                .aspectRatio(contentMode: .fill)
                .offset(x: -70, y: 0)
                .frame(width: 250, height: 400)
                .clipped()

            Text("ヨボー")
                .fontWeight(.light)
                .font(.title)
                .foregroundColor(.white)
                .padding()
                .offset(x: 0, y: -5)
                .frame(width: 250, height: 400)
        }
        .rotation3DEffect(.degrees(45), axis: (x: 1, y: 0, z: 0))

        // ----------------------------
    }
}

struct ShapeView: View {
    var body: some View {
        ZStack {
            Rectangle().rotationEffect(.degrees(45))
            Rectangle().rotationEffect(.degrees(-45))
        }
        .foregroundColor(.green)
        .frame(width: 50, height: 150)
    }
}