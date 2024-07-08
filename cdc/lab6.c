// program to calculate follow of a grammar
#include <stdio.h>
#include <string.h>
#include <ctype.h>
void follow(char[], char);
void findfirst(char[], char);
void addtoresult(char[], char);
int numofproductions;
char productionset[10][10];
int main()
{
    int i;
    int choice;
    char c;
    char result[20];
    printf("How many number of productions ? :");
    scanf("%d", &numofproductions);
    for (i = 0; i < numofproductions; i++)
    {
        printf("Enter productions Number %d : ", i + 1);
        scanf("%s", productionset[i]);
    }
    do
    {
        printf("\n Find the Follow of :");
        scanf(" %c", &c);
        follow(result, c);
        printf("\n Follow(%c)= { ", c);
        for (i = 0; result[i] != '\0'; i++)
            printf(" %c ", result[i]);
        printf("}\n");
        printf("press 1 to continue : ");
        scanf("%d", &choice);
    } while (choice == 1);
    return 0;
}
void follow(char *Result, char c)
{
    int i, j;
    char subresult[20];
    subresult[0] = '\0';
    Result[0] = '\0';
    if (productionset[0][0] == c)
        addtoresult(Result, '$');
    for (i = 0; i < numofproductions; i++)
    {
        for (j = 2; j < strlen(productionset[i]); j++)
        {
            if (productionset[i][j] == c)
            {
                if (productionset[i][j + 1] != '\0')
                    findfirst(subresult, productionset[i][j + 1]);
                if (productionset[i][j + 1] == '\0' && c != productionset[i][0])
                    follow(subresult, productionset[i][0]);
                int k;
                for (k = 0; subresult[k] != '\0'; k++)
                    addtoresult(Result, subresult[k]);
            }
        }
    }
}
void findfirst(char *result, char c)
{
    int i, j;
    char subresult[20];
    int foundepsilon;
    subresult[0] = '\0';
    result[0] = '\0';
    if (!(isupper(c)))
    {
        addtoresult(result, c);
        return;
    }
    for (i = 0; i < numofproductions; i++)
    {
        if (productionset[i][0] == c)
        {
            if (productionset[i][2] == '$')
                addtoresult(result, '$');
            else
            {
                j = 2;
                while (productionset[i][j] != '\0')
                {
                    foundepsilon = 0;
                    findfirst(subresult, productionset[i][j]);
                    for (int k = 0; subresult[k] != '\0'; k++)
                        addtoresult(result, subresult[k]);
                    for (int k = 0; subresult[k] != '\0'; k++)
                        if (subresult[k] == '$')
                        {
                            foundepsilon = 1;
                            break;
                        }
                    if (!foundepsilon)
                        break;
                    j++;
                }
            }
        }
    }
}
void addtoresult(char *result, char val)
{
    int k;
    for (k = 0; result[k] != '\0'; k++)
        if (result[k] == val)
            return;
    result[k] = val;
    result[k + 1] = '\0';
}