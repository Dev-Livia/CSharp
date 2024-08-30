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
