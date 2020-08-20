#include<iostream>
#include<map>
#include<iterator>
using namespace std;

int main()
{
	map<int,int> map1;
	map1.insert({4,5});
	map1.insert({1,2});
	map1.insert({3,4});
	map<int,int> :: iterator itr;
	for(itr = map1.begin();itr!= map1.end();++itr)
		std::cout<< itr->first<<" ~> "<<itr->second<<endl;
	
	return 0;
}
