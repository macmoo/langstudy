import Foundation

func incrementNums(nums:inout [Int]){
    for i in  0..<nums.count{
        nums[i] += 1
    }
}

var data = [3,5,9]
print(data)

incrementNums(nums: &data)
print(data)