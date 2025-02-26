# Interface Usuário

<h2>Módulo 4 - Interface do Usuário</h2>
<p>Neste módulo, aprendemos sobre a criação de interfaces de usuário (UI) na Unity, especificamente a criação de uma <strong>Barra de Vida</strong> e sua animação.</p>

<hr>

<h2>Criando uma UI de Vida na Unity</h2>

<h3>Passo a Passo</h3>

<h4>Passo 1 - Criar um Canvas</h4>
<ol>
    <li>Abra a Unity e crie um novo <strong>Canvas</strong>.</li>
</ol>

<h4>Passo 2 - Criar a Barra de Vida</h4>
<ol>
    <li>Na cena, vá em <strong>UI > Imagem</strong>.</li>
    <li>Renomeie para <strong>Barra de Vida</strong>.</li>
    <li>Adicione uma imagem de sua escolha e ajuste o tamanho.</li>
</ol>

<h4>Passo 3 - Adicionar Ícone de Vida</h4>
<ol>
    <li>Dentro da <strong>Barra de Vida</strong>, vá em <strong>UI > Imagem</strong>.</li>
    <li>Renomeie para <strong>Ícone de Vida</strong>.</li>
    <li>Ajuste o tamanho e posicione corretamente.</li>
</ol>

<h4>Passo 4 - Criar a Barra de Preenchimento</h4>
<ol>
    <li>Ainda dentro da <strong>Barra de Vida</strong>, vá em <strong>UI > Imagem</strong>.</li>
    <li>Renomeie para <strong>Barra</strong>.</li>
    <li>Adicione uma imagem de sua escolha, ajuste o tamanho e posicione corretamente.</li>
</ol>

<h4>Passo 5 - Configurar a Animação da Barra de Vida</h4>
<ol>
    <li>Selecione o objeto <strong>Barra</strong> na Hierarchy.</li>
    <li>No <strong>Inspector</strong>, vá até o componente <strong>Image</strong>.</li>
    <li>Após inserir uma <strong>Sprite</strong>, altere a opção <strong>Image Type</strong> de <strong>Simple</strong> para <strong>Filled</strong>.</li>
    <li>No campo <strong>Fill Origin</strong>, altere para <strong>Left</strong>. Isso permitirá que a barra diminua ou aumente dinamicamente.</li>
</ol>

<hr>

<h2>Exemplo Visual</h2>

<h3>Antes</h3>
<img src="IMG/Img.png" alt="Imagem antes">

<h3>Depois</h3>
<img src="IMG/Image.png" alt="Imagem depois">

<hr>

<h4>Passo 6 - Criar o Script</h4>
<ol>
    <li>Crie um <strong>Script</strong>.</li>
    <li>Adicione a biblioteca <code>using UnityEngine.UI;</code> para utilizar o componente <strong>Image</strong>.</li>
    <li>Desenvolva a lógica para manipular a barra de vida.</li>
</ol>

<h4>Passo 7 - Anexar o Script</h4>
<ol>
    <li>Anexe o script ao objeto <strong>Barra de Vida</strong> na Hierarchy.</li>
</ol>

<h4>Passo 8 - Testar a Barra de Vida</h4>
<ol>
    <li>Pressione <strong>Play</strong> para rodar o projeto.</li>
    <li>No componente do script, altere manualmente o valor da vida para testar a animação de aumento e diminuição.</li>
</ol>

<hr>

<h2>Exemplo Visual de Mudança na Vida</h2>

<h3>Vida Cheia</h3>
<img src="IMG/telaNormal.png" alt="Vida Cheia">

<h3>Diminuição de Vida</h3>
<img src="IMG/TelaMudada.png" alt="Diminuição de Vida">