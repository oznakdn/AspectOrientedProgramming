<h1> ASPECT ORIENTED PROGRAMMING </h1>

<p> AOP kullaniminin temel amaci logging' caching ve transactiong gibi kesisen kaygilarin (cross cutting concerns) <br>
veya fonksiyonel olmayan gereksinimlerin yonetimidir. Proxy ya da Decorator pattern gibi yapilari kullanacak kesisen <br>
endiselerin guvenle yonetildigi moduler yapilar olusturmayi saglar.
</p>


<ol>
<li>Temiz kod bloklari elde etmeyi saglar (clean code) </li>
<li>Kod okunurlugunu kolaylastirir (easier to read)</li>
<li>Hatalara daha az aciktir (less prone to bugs)</li>
<li>Surdurulebilirligi daha kolaydir (easier to maintain)</li>
<li>Kod tekrarlarini azaltir (reduce reperetion)</li>
<li>Test sureclerini kolaylastirir (easier to testing)</li>
</ol>


<p>
<img src="https://www.perfomatix.com/wp-content/uploads/2019/07/AOP-Blog-min.jpg" width="600"> <br>
<img src="https://cdn.sketchbubble.com/pub/media/catalog/product/optimized1/3/6/36b6604fbecc39475cc47e7d072ac33907fada90a3d3523fc19a0822573f1dc7/aspect-oriented-programming-mc-slide2.png" width="600">
</p>


<h2>PROXY</h2>
<p>Istemcinin nesne talep etmesi durumunda gercek nesne ile istemci arasina giren yapi proxy dir.<br>
  Burada istemci gercek nesne yerine proxy nesne ile muhattap olmus oluyor.
</p>
<img src="https://miro.medium.com/v2/resize:fit:1240/1*rKCOCyxJHYjkfo_2iDhQKg.jpeg" width="600"> <br>

<h2>CASTLE DYNAMIC PROXY</h2>
Dotnet de calisma zamaninda (runtime) nesne olusturmayi saglayan bir teknolohidir.
Nuget Package ====> Castle.Core

