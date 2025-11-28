#include <iostream>

using namespace std;

int nwd(unsigned int a, unsigned int b)
{
    while(a!=b)
    {
        if(a>b) a = a-b;
        else b = b-a;
    }
    return a;
}

int main() {
    unsigned int a, b;
    cout << "Podaj a: ";
    cin >> a;
    cout << "Podaj b: ";
    cin >> b;
    cout << "NWD tych dwoch liczb wynosi " << nwd(a, b) << endl;


    return 0;
}