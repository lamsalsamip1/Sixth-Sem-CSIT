// C program to test whether a given identifier is valid or not
#include <stdio.h>
#include <string.h>
#include <ctype.h> // Include ctype.h to use isalpha and isdigit

int main()
{
    char str[100];
    int i, len, flag = 0;
    printf("Enter a string: ");
    gets(str);
    len = strlen(str);

    // Check if the first character is an alphabet letter or '_'
    if (isalpha(str[0]) || str[0] == '_')
    {
        flag = 1;
    }

    // Loop through the rest of the string
    for (i = 1; i < len; i++)
    {
        // Check if each character is an alphabet letter, digit, or '_'
        if (isalpha(str[i]) || isdigit(str[i]) || str[i] == '_')
        {
            flag = 1;
        }
        else
        {
            flag = 0;
            break;
        }
    }

    if (flag == 1)
        printf("It is a valid identifier\n");
    else
        printf("It is not a valid identifier\n");
    return 0;
}