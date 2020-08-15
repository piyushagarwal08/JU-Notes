#include <iostream>
using namespace std;
struct student
{
    string name;
    int roll;
    float marks;
};
int main() 
{
  struct student s1;
  getline(cin,s1.name);
  std::cin>>s1.roll>>s1.marks;
  std::cout<<"\nStudent Details\n"<<"Name: "<<s1.name<<endl;
  std::cout<<"Roll: "<<s1.roll<<endl;
  std::cout<<"Marks: "<<s1.marks<<endl;
  return 0;
}
