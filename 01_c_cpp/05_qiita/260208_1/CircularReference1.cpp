#include <iostream>
#include <memory>

class Object{
public:
    Object(){
        std::cout << "Object의 생성자." << std::endl;
    };
    virtual ~Object(){
        std::cout << "Object의 소멸자." << std::endl;
    };
    void setObjectPtr(const std::shared_ptr<Object>& object_ptr){
        object_ptr_ = object_ptr;
    };
private:
    std::shared_ptr<Object> object_ptr_;
};