// ----------------------------------------
// ContentView.swift
// ----------------------------------------
import SwiftUI

struct ContentView: View {
    var body: some View {
        List(photoArray) { item in
            RowView(photo: item)
        }
    }
}

#Preview {
    ContentView()
}

// ----------------------------------------
// PhotoData.swift
// ----------------------------------------
import Foundation

struct PhotoData: Identifiable {
    var id = UUID()
    var imageName: String
    var title: String
}

var photoArray = [
    PhotoData(imageName: "IMG_0996", title: "湘南平展望レストランFlat"),
    PhotoData(imageName: "IMG_1035", title: "アウトリガーカヌー"),
    PhotoData(imageName: "IMG_1504", title: "えぼし号"),
    PhotoData(imageName: "IMG_1531", title: "富士山"),
    PhotoData(imageName: "IMG_2139", title: "DENTAL CLINIC"),
    PhotoData(imageName: "IMG_2250", title: "鵠沼漁港白灯台"),
    PhotoData(imageName: "IMG_2269", title: "サザンビーチ海の家"),
    PhotoData(imageName: "IMG_2470", title: "天使の翼"),
    PhotoData(imageName: "IMG_2883", title: "スイミングスクールバス"),
    PhotoData(imageName: "IMG_4199", title: "小田急線江ノ島駅"),
    PhotoData(imageName: "IMG_6460", title: "鷹取山"),
    PhotoData(imageName: "IMG_7122", title: "支笏湖ぼスワンボート"),
    PhotoData(imageName: "IMG_7216", title: "とまチョップ"),
    PhotoData(imageName: "IMG_7745", title: "スナックJunko"),
    PhotoData(imageName: "IMG_7851", title: "山の電話ボックス"),
]

// ----------------------------------------
// RowView.swift
// ----------------------------------------
import SwiftUI

struct RowView: View {
    var photo: PhotoData
    var body: some View {
        HStack {
            Image(photo.imageName)
                .resizable()
                .frame(width: 60, height: 60)
                .clipShape(Circle())
                .overlay(Circle().stroke(Color.gray))
            Text(photo.title)
            Spacer()
        }
    }
}

struct RowView_Previews: PreviewProvider {
    static var previews: some View {
        RowView(photo: photoArray[0])
            .previewLayout(.sizeThatFits)
    }
}
// ----------------------------------------
