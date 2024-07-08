// C program for final code generation
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void generateMachineCode(const char *expression, FILE *outputFile)
{
    char operand1 = 0, operand2 = 0, operator= 0;

    // Assuming a simple expression like "a + b"
    if (sscanf(expression, "%c %c %c", &operand1, &operator, & operand2) == 3)
    {
        switch (operator)
        {
        case '+':
            fprintf(outputFile, "ADD %c, %c\n", operand1, operand2);
            break;
        case '-':
            fprintf(outputFile, "SUB %c, %c\n", operand1, operand2);
            break;
        case '*':
            fprintf(outputFile, "MUL %c, %c\n", operand1, operand2);
            break;
        case '/':
            fprintf(outputFile, "DIV %c, %c\n", operand1, operand2);
            break;
        case '=':
            fprintf(outputFile, "MOV %c, %c\n", operand1, operand2); // Assuming MOV for assignment
            break;
        default:
            fprintf(outputFile, "Unknown operation\n");
        }
    }
    else
    {
        fprintf(outputFile, "Error parsing expression\n");
    }
}

int main()
{
    FILE *inputFile, *outputFile;
    char expression[20];

    inputFile = fopen("input.txt", "r"); // Open the file for reading
    if (inputFile == NULL)
    {
        perror("Error opening input file");
        return -1;
    }

    outputFile = fopen("output.txt", "w"); // Open the file for writing
    if (outputFile == NULL)
    {
        perror("Error opening output file");
        fclose(inputFile); // Make sure to close inputFile if outputFile fails to open
        return -1;
    }

    while (fgets(expression, sizeof(expression), inputFile) != NULL)
    {
        // Remove newline character if present
        expression[strcspn(expression, "\n")] = 0;
        generateMachineCode(expression, outputFile);
    }

    fclose(inputFile);  // Close the input file
    fclose(outputFile); // Close the output file
    return 0;
}