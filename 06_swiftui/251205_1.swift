import SwiftUI

struct ContentView: View {
    var body: some View {
        VStack {
            Text("Bicycle for the Mind")
                .font(.title)
                .fontWeight(.light)
                .padding(/*@START_MENU_TOKEN@*/.all/*@END_MENU_TOKEN@*/,50)
                
                
            Text("지성의 자동차")
                .foregroundColor(Color.red)
                .padding(/*@START_MENU_TOKEN@*/.all/*@END_MENU_TOKEN@*/)
                
        
            Text("What it means is that you've trained yourself to respond in a way that helps you move forward no matter the situation. ")
                .multilineTextAlignment(.center)
                // .leading, .tailing
                .lineLimit(2)
                .frame(width: 200.0, height: 300.0)
            
            Text("ABCDEFGHIJKLMNOPQRSTUVWXYZ")
                .frame(width: 250, height: 200, alignment: .topTrailing)
                .fontWeight(.heavy)
                .padding()
        }
        .padding()
    }
}