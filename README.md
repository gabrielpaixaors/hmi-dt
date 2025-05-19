# HMI DT

**Ferramenta de Geração Automática de Mimics para IHM**  
Aplicação Windows (WPF/.NET Framework) iniciada para automatizar a criação de telas de IHM (mimics) a partir de um arquivo template e dados de entrada.

## Tecnologias
- C#  
- WPF (.NET Framework 4.7.2)  
- MVVM Light  
- Leitura de template (XML/JSON) e manipulação de arquivos  
- **Expressões Regulares (Regex)** para identificar padrões e filtrar parâmetros flexivelmente

## Funcionalidades Planejadas
1. **Carregamento de template**: seleção de arquivo modelo de mimic com placeholders.  
2. **Configuração de parâmetros**: usuário define nome de saída, dados de entrada e regras de mapeamento.  
3. **Processamento automático**: algoritmo em desenvolvimento usa Regex e lógica de mapeamento para converter input em parâmetros e inserir símbolos na tela gerada.  
4. **Exportação**: geração do arquivo de mimic pronto para importação na IHM.  
5. **Logs**: detalhamento do que foi processado e do tamanho antes/depois.

> **Status:** em fase inicial – núcleo do algoritmo ainda em desenvolvimento.

## Benefícios Esperados
- Redução de até X horas em tarefas manuais de criação de mimics.  
- Padronização de nomenclatura e estrutura de telas.  
- Menor chance de erro humano.

## Como rodar
1. Clone o repositório e abra a solução `HMI DT.sln` no Visual Studio 2019+.  
2. Restaure pacotes NuGet (MVVM Light, libs de IO).  
3. Compile e execute em **Debug** ou **Release**.  
4. Carregue o template e defina os dados de entrada na interface.

## Próximos Passos
- Implementar o algoritmo de mapeamento completo.  
- Testar com exemplos reais de sinóticos.  
- Adicionar arquivos de exemplo em `docs/`.
