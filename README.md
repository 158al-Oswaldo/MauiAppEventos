# MauiAppEventos – Cadastro de Eventos (.NET MAUI)

Projeto da atividade de Programação Mobile I (Agenda 15).

## Estrutura

```
Models/Evento.cs                 -> model (propriedades + DuracaoDias, Diferenca (TimeSpan), CustoTotal)
Views/CadastroEvento.xaml(.cs)   -> tela de cadastro (Entry, DatePicker, Button)
Views/ResumoEvento.xaml(.cs)     -> tela de resumo (Bindings + StringFormat)
App.xaml.cs                      -> NavigationPage com a tela de cadastro como inicial
```

## Como montar no Visual Studio 2022

1. Criar novo projeto **Aplicativo .NET MAUI** com o nome `MauiAppEventos` (.NET 8).
2. Criar as pastas `Models` e `Views`.
3. Em `Models`, adicionar a classe `Evento` e colar o conteúdo de `Models/Evento.cs`.
4. Em `Views`, adicionar duas **ContentPage (XAML)**: `CadastroEvento` e `ResumoEvento`, e substituir o conteúdo dos `.xaml` e `.xaml.cs` pelos arquivos deste projeto.
5. Substituir o `App.xaml.cs` pelo deste projeto (em projetos .NET 9 use `protected override Window CreateWindow(...)` retornando `new Window(new NavigationPage(new CadastroEvento()))`).
6. Pode excluir `MainPage.xaml` e `AppShell.xaml` (opcional).
7. Executar (Windows Machine ou emulador Android).

## Conceitos usados

- **BindingContext**: a tela de cadastro cria o objeto `Evento` e o envia à página `ResumoEvento` com `BindingContext = ev`.
- **DateTime / TimeSpan**: `DataTermino - DataInicio` resulta em `TimeSpan`, exibido na tela de resumo.
- **StringFormat**: `{0:dd/MM/yyyy}` para datas e `{0:C}` para moeda.
- **Método assíncrono**: `async` / `await` em `Button_Clicked` com `Navigation.PushAsync` e `DisplayAlert`.

## Entrega

- GitHub: criar repositório, subir o projeto (sem `bin/` e `obj/`) e enviar o link.
- PDF com capturas de tela (tela de cadastro preenchida + tela de resumo) **ou** vídeo explicando o código.
