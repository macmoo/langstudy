import SwiftUI

// View프로토콜을 구현
struct ContentView: View {
    // body프로퍼티
    // - ContentView의 몸통을 나타내는 프로퍼티.
    // - View프로토콜을 구현할 때는 반드시 필요.
    var body: some View {
        // "some View"가 타입으로 지정됨
        // {}프로퍼티:Computed프로퍼티
        // - returnされた値がプロパティに値として設定される
        // "some":"Opaque Result Type". ”何か”
        // - Viewである何か
        // - "View"として扱える何かのオブジェクト
        Text("Hello World!")
            // Modifier:プロトコルメソッドとして提供
            // - Textの場合は、ベースのViewのModifierとTextのModiferを使える。
            // - コントロールにはModifierという仕組みがあって、それでさまざまな表紙の設定を行う機能が実装されている。
            // .font(.title) // Font.title(Fontのプロパティ)
            // Font.system(size: 수치)
            // Font.custom(폰트패밀리명, size: 수치)
            .font(.system(size:70.0))
            // .font(.custom("Marker Felt", size: 60.0))
            // .foregroundColor(Color.blue) // 폰트색, Text의 Modifier
            .foregroundColor(Color(red:1.0, green: 0.5, blue: 0.25))
            .bold()
            .italic()
            // <<Text>>.fontWeight(<<Font.Weight>>)
            .fontWeight(.black) // 굵기 조정
            .multilineTextAlignment(.center)
            .lineLimit(5)
            // .padding(50)
            // <<View>>.padding(<<Edge.Set>>, 値)
            // .padding(.all)
            // - .vertical/.horizontal/.top/.bottom/.leading/.trailing
            .padding(Edge.Set.vertical, 50.0) // 上下지정
            .padding(.horizontal, 30.0) // 左右지정
            // <<View>>.position(x: val, y: val)
            // 부품의 위치는 부품중심의 위치
             .position(x: 110.0, y: 100.0)
            // .position(x: 0, y: 0)
            // <<View>>.frame(width: val, height: val)
            .frame(width: 300.0, height: 400.0)
            // background()는 View의 Modifier니까 순서가 중요
            .background(Color.blue)
            // <<View>>.border(<<Color>>, width: val)
            .border(Color.red, width:10)
    }
}

#Preview {
    ContentView()
}
