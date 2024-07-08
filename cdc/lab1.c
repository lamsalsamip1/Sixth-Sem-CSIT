// program to test whether entered string is a valid comment or not
#include <stdio.h>
#include <string.h>
int main()
{
    char str[100];
    int i, len, flag = 0;
    printf("Enter a string: ");
    gets(str);
    len = strlen(str);
    if (str[0] == '/' && str[1] == '/')
    {
        flag = 1;
    }
    else if (str[0] == '/' && str[1] == '*' && str[len - 2] == '*' && str[len - 1] == '/')
    {
        flag = 1;
    }

    if (flag == 1)
    {
        printf("It is a comment\n");
    }
    else
    {
        printf("It is not a comment\n");
    }
    return 0;
}