#include<iostream>
#include<string>
#include<bits\stdc++.h>
using namespace std;

struct Student
{
  char name[30],department[20];
  int yearOfStudy;
  float cgpa;
};

Student getDetails(Student);
void printDetails(Student);

int Comparator(const void* p,const void *q)
{
	return strcmp(((struct Student*)p)->name,((struct Student*)q)->name);
}

int main()
{
  //Type your code here.
  int n;
  std::cout<<"Enter the number of students"<<endl;
  std::cin>>n;
  Student arr[n];
  for(int i=0;i<n;i++)
  {
    std::cout<<"Enter the details of student "<<i+1<<endl;
    arr[i] = getDetails(arr[i]);
  }
  qsort(arr,n,sizeof(struct Student),Comparator);
  
  std::cout<<"Details of students"<<endl;
  for(int i=0;i<n;i++)
  {
    std::cout<<"Student "<<i+1<<endl;
    printDetails(arr[i]);
  }
  return 0;   
}

Student getDetails(Student s)
{
  std::cout<<"Enter name"<<endl;
  std::cin>>s.name;
  std::cout<<"Enter department"<<endl;
  std::cin>>s.department;
  std::cout<<"Enter year of study"<<endl;
  std::cin>>s.yearOfStudy;
  std::cout<<"Enter cgpa"<<endl;
  std::cin>>s.cgpa;
  return s;
}

void printDetails(Student s)
{
  std::cout<<"Name:"<<s.name<<endl;
  std::cout<<"Department:"<<s.department<<endl;
  std::cout<<"Year of study:"<<s.yearOfStudy<<endl;
  std::cout<<"CGPA:"<<s.cgpa<<endl;
  return;
}
