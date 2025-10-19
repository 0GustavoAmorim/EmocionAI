# 🎨 EmotionDrawing — Decifrando Emoções com Arte e Inteligência Artificial

> “A arte é a expressão mais pura da alma humana e agora, a IA pode nos ajudar a ouvi-la.”

---

## Sobre o Projeto

O **EmotionDrawing** (também chamado de **EmocionAI!**) é uma aplicação experimental que une **Inteligência Artificial**, **arte** e **cuidado emocional**.  
Através de técnicas de **Visão Computacional** e **Machine Learning**, o sistema é capaz de **analisar desenhos infantis** e **identificar emoções predominantes** expressas neles, como felicidade, tristeza, raiva e medo.

O projeto nasceu da vontade de **usar tecnologia como aliada da empatia**, inspirado pela história do **Museu de Arte Osório César (MAOC)**, em Franco da Rocha (SP), cidade marcada por sua ligação com a saúde mental e o antigo Hospital do Juquery.

---

## Contexto e Inspiração

Como morador de **Franco da Rocha**, sempre estive próximo de histórias e memórias do **Hospital Psiquiátrico do Juquery**, na sua epóca o maior hospital psiquiatrico da América Latina.  
Ao visitar o **MAOC**, entrei em contato com obras produzidas por pacientes psiquiátricos, expressões sinceras de dor, sonho e humanidade.

Essas experiências me inspiraram a criar o **EmocionAI**: uma ferramenta que busca traduzir sentimentos invisíveis, **dando voz ao universo emocional das crianças** através de seus desenhos.

---

## Como Funciona

O fluxo do **EmocionAI!** é simples e empático:

1. 👧 A criança faz um desenho (em papel ou digital).  
2. 🧑‍🏫 Um educador, psicólogo ou terapeuta envia a imagem ao sistema.  
3. 🤖 A IA analisa cores, traços e formas, retornando a emoção predominante.  

Atualmente, o modelo reconhece **quatro emoções básicas**:
- 😊 **Felicidade**
- 😢 **Tristeza**
- 😠 **Raiva**
- 😨 **Medo**

Em futuras versões, pretendo incluir emoções mais complexas, como **ansiedade**, **tédio**, **confusão**, **surpresa** e **vergonha**, inspirando-se na evolução dos sentimentos retratada em *Divertidamente*.
O modelo que estou usando até o momento foi treinado com apenas 836 imagens de desenhos, sendo eles:

| Emoção | Quantidade |
|-------------|--------|
| **Alegria** | 167 |
| *Medo** | 218 |
| **Raiva** | 219 |
| **Tristeza** | 232 |

Com uma presição média de 74.3% em três iterações, ainda preciso trabalhar muito em treinamento e base de imagens para alcançar um número ideal.

---

## Aplicações Possíveis

- 🩺 **Apoio à saúde mental infantil**:  
  psicólogos e terapeutas podem usar o sistema para interpretar rapidamente o estado emocional de crianças.  
- 🎨 **Arteterapia com tecnologia**:  
  potencializa a expressão artística como ferramenta terapêutica.  
- 🔎 **Detecção precoce de sofrimento emocional**:  
  auxilia na identificação de traumas ou sinais de abuso.  
- 🗣️ **Inclusão e escuta ativa**:  
  oferece uma forma de comunicação emocional para crianças não verbais.  
- 💡 **Inovação social e educacional**:  
  promove o uso da IA para o bem-estar em escolas e projetos sociais.

---

## 🧰 Tecnologias Utilizadas

| Tecnologia | Função |
|-------------|--------|
| **.NET 9 (Blazor Server)** | Frontend e Backend unificados |
| **Azure Custom Vision** | Treinamento e inferência do modelo de classificação de imagens |
| **C#** | Lógica de aplicação e integração com API da Azure |
| **HTML/CSS (Blazor Components)** | Interface e exibição de resultados |
| **GitHub Actions (futuro)** | CI/CD e automação de deploy |

---

## 🚀 Estrutura do Projeto

```
EmotionDrawingClassifier/
│
├── EmotionDrawing.Blazor/       # Interface principal (Blazor .NET 9)
├── EmotionDrawing.Core/         # Lógica e modelos de domínio
├── EmotionDrawing.Services/     # Integração com Azure Custom Vision
├── EmotionDrawing.Tests/        # Testes unitários e de integração
├── README.md                    # Você está aqui
└── EmotionDrawing.sln           # Solução principal do projeto
```
---

##  Ideias/Continuidade do projeto

- [ ] Melhorar o dataset com mais amostras de desenhos reais  
- [ ] Adicionar novas emoções complexas  
- [ ] Interface mais lúdica e acessível para crianças  
- [ ] Dashboard para terapeutas e educadores  
- [ ] Deploy e disponibilizar de maneira gratuita ao público 

---

## ❤️ Propósito

O **EmocionAI** é mais do que um projeto de IA.  
É uma ferramenta de **empatia, escuta e cuidado humano**.  
Seu propósito é democratizar o acesso à análise emocional e apoiar profissionais na missão de **cuidar do invisível**, os sentimentos.

> “A tecnologia não substitui o olhar humano, mas pode ampliá-lo.”

---

## 📸 Créditos e Referências

- Museu de Arte Osório César (MAOC) — Franco da Rocha/SP  
- Inspiração em *Osório César*, psiquiatra pioneiro da arteterapia no Brasil  
- Projeto desenvolvido por [**Gustavo Amorim**](https://github.com/0GustavoAmorim)  
- Texto adaptado da [postagem original no LinkedIn]([https://www.linkedin.com/feed/update/urn:li:activity:7333988818846412800/](https://www.linkedin.com/posts/gustavo-amorim-silva_decifrando-emo%C3%A7%C3%B5es-com-arte-e-intelig%C3%AAncia-activity-7333988818846412800-rRHd?utm_source=share&utm_medium=member_desktop&rcm=ACoAADokX8IB7-2ediWLKzAtYPTVXzbHxOTP-6Q))

---

## 📄 Licença

Este projeto está sob a licença [MIT](LICENSE).

---

**EmocionAI — Transformando técnologia e arte em empatia.**
