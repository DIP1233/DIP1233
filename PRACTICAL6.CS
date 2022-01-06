#include<iostream.h>
#include<conio.h>
class sample
{
    int a,b:
    friend void print(sample);
};
void print(sample s)
{
    s.a=10;
    s.b=20;
cout<<"a"<<s.a;
cout<<"b"<<s.b;
}
void main()
{
    clrscr();
    sample s;
    print(s);
    getch();
}