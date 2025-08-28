# 🍔 Lanchonete Pro — Sistema de Pedidos em C# (Console)

Um sistema completo de **gestão de pedidos para lanchonetes**, feito em **C# Console**, com **persistência em JSON**, emissão de recibos e relatórios.  

## ✨ Funcionalidades

- **Cadastro de produtos**
  - Nome, categoria (Lanche, Bebida, Sobremesa, Acompanhamento), preço e status (ativo/inativo).
  - Editar, remover ou desativar produtos sem perder histórico.

- **Pedidos**
  - Adicionar, editar ou remover itens do pedido.
  - Aplicar **descontos** (valor em R$ ou percentual).
  - Definir **taxa de serviço (%)**.
  - Suporte a **formas de pagamento**: Dinheiro, Cartão e Pix.
  - Cálculo automático de **troco** (quando pagamento em dinheiro).
  - **Emissão de recibo** no console e salvamento em arquivo `.txt`.

- **Relatórios**
  - Total de vendas do dia.
  - Listagem detalhada de pedidos do dia.
  - Cálculo de **ticket médio**.

- **Persistência**
  - Dados de produtos e pedidos salvos automaticamente em **JSON**.
  - Arquivos armazenados na pasta `/dados`.

- **Usabilidade**
  - Busca de produtos por código, nome ou categoria.
  - Cardápio exibido de forma organizada por categoria.

---

## 📂 Estrutura de Arquivos

