#include <bits/stdc++.h> 
using namespace std; 
  
void makeCombiUtil(vector<vector<int> >& ans,vector<int>& tmp, int n, int left, int k,int *a) 
{ 
    // Pushing this vector to a vector of vector 
    if (k == 0) { 
        ans.push_back(tmp); 
        return; 
    } 
  
    // i iterates from left to n. First time 
    // left will be 1 
    for (int i = left; i < n; ++i) 
    { 
        tmp.push_back(*(a+i)); 
        makeCombiUtil(ans, tmp, n, i + 1, k - 1,a); 
        tmp.pop_back(); 
    } 
} 
  
// Prints all combinations of size k of numbers 
// from 1 to n. 
vector<vector<int> > makeCombi(int n, int k,int *a) 
{ 
    vector<vector<int> > ans; 
    vector<int> tmp; 
    makeCombiUtil(ans, tmp, n, 0, k,a); 
    return ans; 
} 
  

int main() 
{ 
    // given number 
    int n = 4; 
    int k = 4; 
    int a[] = {3,6,1,9};
    vector<vector<int> > ans = makeCombi(n, k,a); 
    for (int i = 0; i < ans.size(); i++) { 
        for (int j = 0; j < ans[i].size(); j++) { 
            cout << ans.at(i).at(j) << " "; 
        } 
        cout << endl; 
    } 
    return 0; 
}
