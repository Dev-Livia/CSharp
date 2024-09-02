# C#
 
## Tipos Básicos de Dados em C#

Em C#, os tipos básicos de dados são usados para armazenar valores de diferentes naturezas, como números, caracteres e valores booleanos. Esses tipos são diretamente suportados pela linguagem e são parte do .NET Framework.

### 1. **Tipos Numéricos Inteiros**
   - **`int`**: Um tipo inteiro de 32 bits com sinal. Intervalo: `-2,147,483,648` a `2,147,483,647`.
   - **`long`**: Um tipo inteiro de 64 bits com sinal. Intervalo: `-9,223,372,036,854,775,808` a `9,223,372,036,854,775,807`.
   - **`short`**: Um tipo inteiro de 16 bits com sinal. Intervalo: `-32,768` a `32,767`.
   - **`byte`**: Um tipo inteiro de 8 bits sem sinal. Intervalo: `0` a `255`.
   - **`sbyte`**: Um tipo inteiro de 8 bits com sinal. Intervalo: `-128` a `127`.
   - **`uint`**: Um tipo inteiro de 32 bits sem sinal. Intervalo: `0` a `4,294,967,295`.
   - **`ulong`**: Um tipo inteiro de 64 bits sem sinal. Intervalo: `0` a `18,446,744,073,709,551,615`.
   - **`ushort`**: Um tipo inteiro de 16 bits sem sinal. Intervalo: `0` a `65,535`.

### 2. **Tipos Numéricos de Ponto Flutuante**
   - **`float`**: Um tipo de ponto flutuante de precisão simples de 32 bits. Intervalo: ±1.5e−45 a ±3.4e38, com 7 dígitos de precisão.
   - **`double`**: Um tipo de ponto flutuante de precisão dupla de 64 bits. Intervalo: ±5.0e−324 a ±1.7e308, com 15-16 dígitos de precisão.
   - **`decimal`**: Um tipo de ponto flutuante de 128 bits utilizado para cálculos financeiros e monetários. Intervalo: ±1.0e−28 a ±7.9e28, com 28-29 dígitos de precisão.

### 3. **Tipos Lógicos**
   - **`bool`**: Um tipo que pode armazenar apenas os valores `true` ou `false`.

### 4. **Tipos de Caracteres**
   - **`char`**: Um tipo de 16 bits que representa um único caractere Unicode. Intervalo: `U+0000` a `U+FFFF`.

### 5. **Tipo de Cadeia de Caracteres**
   - **`string`**: Um tipo que representa uma sequência de caracteres Unicode. Ele é imutável, o que significa que, uma vez criado, seu valor não pode ser alterado.

### 6. **Tipo de Valor Nulo**
   - **`object`**: O tipo base para todos os tipos de dados em C#. Pode armazenar qualquer tipo de dado, incluindo tipos de valor e tipos de referência.
   - **`null`**: Representa a ausência de um valor. Pode ser atribuído a tipos de referência.

### Exemplo de Uso:

```csharp
int idade = 25;
float altura = 1.75f;
bool eEstudante = true;
char inicial = 'A';
string nome = "João";
```
## Restrições e Convenções para Nomes em C#

Em C#, a nomeação de variáveis, métodos, classes e outros identificadores deve seguir certas regras e convenções para garantir legibilidade, consistência e evitar erros.

### **Restrições para Nomes**
   - **Caractere inicial**: Os nomes devem começar com uma letra (`a-z`, `A-Z`) ou um sublinhado (`_`). Números não podem ser usados no início do nome.
   - **Uso de caracteres especiais**: Além de letras, números e sublinhados, não são permitidos outros caracteres especiais como `@`, `#`, `$`, etc., exceto para prefixar identificadores com o símbolo `@` para evitar conflitos com palavras-chave (por exemplo, `@class`).
   - **Palavras-chave**: Não é permitido usar palavras reservadas do C# como identificadores (ex.: `int`, `class`, `void`). No entanto, é possível usar o prefixo `@` para contornar isso (ex.: `@int`).
   - **Comprimento**: Embora não haja um limite estrito no comprimento dos nomes, é recomendado manter os nomes descritivos, porém concisos.

   **Exemplos:**

   ```
   int _idade;         // Válido
   string nome1;       // Válido
   double @class;      // Válido, mas não recomendado
   int 123numero;      // Inválido, começa com número
```
## Saída de Dados em C#

Em C#, a saída de dados é frequentemente realizada usando o método `Console.WriteLine()` para exibir informações no console. Este método é parte da classe `Console`, que fornece diversas funcionalidades para entrada e saída de dados.

### **Método `Console.WriteLine()`**
   O método `Console.WriteLine()` é utilizado para exibir uma linha de texto no console, seguida por uma nova linha. Ele pode ser usado para exibir variáveis, textos, ou combinações dos dois.

   **Exemplo:**

   ```
   Console.WriteLine("Hello, World!");  // Exibe "Hello, World!"
   Console.WriteLine(42);               // Exibe o número 42
```
## Operadores de Atribuição em C#

Os operadores de atribuição em C# são usados para atribuir valores a variáveis. O operador de atribuição mais comum é o `=`, mas existem outros operadores que realizam operações adicionais ao mesmo tempo que atribuem valores.

### 1. **Operador de Atribuição Simples (`=`)**
   O operador `=` atribui o valor do lado direito à variável do lado esquerdo.

   **Exemplo:**

   ```
   int x = 10;  // Atribui o valor 10 à variável x
```
### Exemplo de Atribuição com `a++` e `a--`

Os operadores de incremento (`++`) e decremento (`--`) são utilizados para adicionar ou subtrair `1` ao valor de uma variável. Eles podem ser usados de forma **pós-fixada** (após a variável) ou **pré-fixada** (antes da variável).

#### **Pós-fixado (`a++`, `a--`)**
   No modo pós-fixado, a variável é usada primeiro, e depois é incrementada ou decrementada.

   **Exemplo:**

   ```
   int a = 5;
   int b = a++;  // b recebe o valor 5, e então a é incrementado para 6
   int c = a--;  // c recebe o valor 6, e então a é decrementado para 5

   Console.WriteLine($"a: {a}, b: {b}, c: {c}");
```
## Conversão Implícita e Casting em C#

Em C#, conversões entre tipos de dados podem ser feitas de forma **implícita** ou **explícita** (casting). A escolha entre uma e outra depende do tipo de dados envolvidos e do risco de perda de informação.

###**Conversão Implícita**
   A conversão implícita ocorre automaticamente quando não há risco de perda de dados. Ela é realizada pelo compilador quando um tipo menor é convertido para um tipo maior.

   **Exemplo:**

   ```
   int num = 10;
   double valor = num; // Conversão implícita de int para double
```
## Operadores Aritméticos em C#

Os operadores aritméticos em C# são usados para realizar operações matemáticas básicas, como adição, subtração, multiplicação, divisão e cálculo de resto. Esses operadores podem ser aplicados a tipos numéricos, como `int`, `float`, `double`, entre outros.

### **Operador de Adição (`+`)**
   - **Descrição**: Soma dois valores.
   - **Exemplo**:
     ```csharp
     int a = 5;
     int b = 3;
     int resultado = a + b;  // resultado é 8
     ```

### **Operador de Subtração (`-`)**
   - **Descrição**: Subtrai o segundo valor do primeiro.
   - **Exemplo**:
     ```csharp
     int a = 5;
     int b = 3;
     int resultado = a - b;  // resultado é 2
     ```

###**Operador de Multiplicação (`*`)**
   - **Descrição**: Multiplica dois valores.
   - **Exemplo**:
     ```csharp
     int a = 5;
     int b = 3;
     int resultado = a * b;  // resultado é 15
     ```

### **Operador de Divisão (`/`)**
   - **Descrição**: Divide o primeiro valor pelo segundo. No caso de divisão entre inteiros, o resultado é um valor inteiro (a parte fracionária é descartada).
   - **Exemplo**:
     ```csharp
     int a = 10;
     int b = 3;
     int resultado = a / b;  // resultado é 3 (parte fracionária é descartada)

     double c = 10.0;
     double d = 3.0;
     double resultadoComDecimal = c / d;  // resultado é 3.3333...
     ```

### **Operador de Módulo (`%`)**
   - **Descrição**: Retorna o resto da divisão do primeiro valor pelo segundo.
   - **Exemplo**:
     ```
     int a = 10;
     int b = 3;
     int resto = a % b;  // resto é 1
     ```

### **Operador de Incremento (`++`)**
   - **Descrição**: Incrementa o valor da variável em 1. Pode ser usado em forma pós-fixada (`a++`) ou pré-fixada (`++a`).
   - **Exemplo**:
     ```
     int a = 5;
     a++;  // a agora é 6
     ```

### **Operador de Decremento (`--`)**
   - **Descrição**: Decrementa o valor da variável em 1. Pode ser usado em forma pós-fixada (`a--`) ou pré-fixada (`--a`).
   - **Exemplo**:
     ```csharp
     int a = 5;
     a--;  // a agora é 4
     ```

### Exemplo de Uso Completo:

```
int a = 10;
int b = 3;

int soma = a + b;          // soma é 13
int subtracao = a - b;     // subtracao é 7
int multiplicacao = a * b; // multiplicacao é 30
int divisao = a / b;       // divisao é 3 (divisão inteira)
int resto = a % b;         // resto é 1

a++;  // a agora é 11
b--;  // b agora é 2
```
## Entrada de Dados em C#

Em C#, a entrada de dados é frequentemente realizada usando o método `Console.ReadLine()`, que permite ao usuário inserir informações via console. Essas entradas são capturadas como strings e podem ser convertidas para outros tipos de dados conforme necessário.

###  **Método `Console.ReadLine()`**
   O método `Console.ReadLine()` lê uma linha completa de entrada do usuário até que ele pressione Enter. O valor lido é retornado como uma string.

   **Exemplo:**

   ```
   Console.WriteLine("Digite seu nome:");
   string nome = Console.ReadLine();  // Captura a entrada do usuário e armazena na variável 'nome'
   Console.WriteLine($"Olá, {nome}!");
```
## Operadores Comparativos em C#

Os operadores comparativos em C# são usados para comparar valores. Eles retornam um valor booleano (`true` ou `false`) com base na relação entre os operandos. Esses operadores são frequentemente utilizados em estruturas de controle de fluxo, como condicionais (`if`, `else`) e loops (`while`, `for`).

### **Operador de Igualdade (`==`)**
   - **Descrição**: Verifica se dois valores são iguais.
   - **Exemplo**:
     ```
     int a = 5;
     int b = 5;
     bool resultado = (a == b);  // resultado é true
     ```

### **Operador de Diferença (`!=`)**
   - **Descrição**: Verifica se dois valores são diferentes.
   - **Exemplo**:
     ```
     int a = 5;
     int b = 3;
     bool resultado = (a != b);  // resultado é true
     ```

###  **Operador Maior que (`>`)**
   - **Descrição**: Verifica se o primeiro valor é maior que o segundo.
   - **Exemplo**:
     ```
     int a = 5;
     int b = 3;
     bool resultado = (a > b);  // resultado é true
     ```

###  **Operador Menor que (`<`)**
   - **Descrição**: Verifica se o primeiro valor é menor que o segundo.
   - **Exemplo**:
     ```
     int a = 5;
     int b = 7;
     bool resultado = (a < b);  // resultado é true
     ```

###  **Operador Maior ou Igual (`>=`)**
   - **Descrição**: Verifica se o primeiro valor é maior ou igual ao segundo.
   - **Exemplo**:
     ```
     int a = 5;
     int b = 5;
     bool resultado = (a >= b);  // resultado é true
     ```

###  **Operador Menor ou Igual (`<=`)**
   - **Descrição**: Verifica se o primeiro valor é menor ou igual ao segundo.
   - **Exemplo**:
     ```
     int a = 5;
     int b = 7;
     bool resultado = (a <= b);  // resultado é true
     ```

### Exemplo de Uso Completo:

```
int a = 10;
int b = 20;

bool igual = (a == b);         // igual é false
bool diferente = (a != b);     // diferente é true
bool maior = (a > b);          // maior é false
bool menor = (a < b);          // menor é true
bool maiorOuIgual = (a >= b);  // maiorOuIgual é false
bool menorOuIgual = (a <= b);  // menorOuIgual é true

Console.WriteLine($"a == b: {igual}");
Console.WriteLine($"a != b: {diferente}");
Console.WriteLine($"a > b: {maior}");
Console.WriteLine($"a < b: {menor}");
Console.WriteLine($"a >= b: {maiorOuIgual}");
Console.WriteLine($"a <= b: {menorOuIgual}");
```
## Operadores Lógicos em C#

Os operadores lógicos em C# são utilizados para combinar expressões booleanas ou inverter o valor de uma expressão booleana. Eles são essenciais para criar condições complexas em estruturas de controle de fluxo, como condicionais (`if`, `else`) e loops (`while`, `for`).

### Operadores Lógicos

- **`&&` (AND lógico)**: Retorna `true` se **ambas** as expressões forem verdadeiras.
  - **Exemplo**:
    ```csharp
    bool resultado = (5 > 3) && (10 > 8);  // resultado é true
    ```

- **`||` (OR lógico)**: Retorna `true` se **pelo menos uma** das expressões for verdadeira.
  - **Exemplo**:
    ```csharp
    bool resultado = (5 > 3) || (10 < 8);  // resultado é true
    ```

- **`!` (NOT lógico)**: Inverte o valor de uma expressão booleana.
  - **Exemplo**:
    ```csharp
    bool verdadeiro = true;
    bool resultado = !verdadeiro;  // resultado é false
    ```

### Exemplo de Uso Completo:

```
bool condicao1 = (5 > 3);  // true
bool condicao2 = (10 < 8); // false

// AND lógico - Ambos devem ser verdadeiros
bool resultadoAnd = condicao1 && condicao2;  // resultadoAnd é false

// OR lógico - Pelo menos um deve ser verdadeiro
bool resultadoOr = condicao1 || condicao2;   // resultadoOr é true

// NOT lógico - Inverte o valor
bool resultadoNot = !condicao1;              // resultadoNot é false

Console.WriteLine($"AND lógico: {resultadoAnd}");
Console.WriteLine($"OR lógico: {resultadoOr}");
Console.WriteLine($"NOT lógico: {resultadoNot}");
```
