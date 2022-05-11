# AuthApps

Ta Solucja, projekty w niej zawarte a przede wszystkim ich opisy mają na celu wprowadzenie w świat aplikacji webowych budowanych w technologiach ASP.NET ze szczególnym 
skupieniem się na temacie uwierzytelniania i autoryzacji. W pewnym sensie upraszczając, webowe aplikacje można rodzielić na 3 sfery:

1. obsługę baz danych i logikę biznesową, z którą sprawnie poradzi sobie kazdy developer mający doświadczenie na głebokim backendzie ( aplikacje konsolowe, biblioteki )
2. HTML, CSS, javascript, czyli frontend aplikacji. Jej design oraz UI/UX , czyli całe to operowanie na aplikacji w przeglądarce.
3. Płytki Backend, związany z tym jak serwer odpowiada na rządania płynace z przegladarki. jak to się chociażby dzieje, że  przechodząc pomiędzy poszczególnymi stronami naszej aplikacji,system wie kim jesteśmy, czy może nam pokazać pewne dane i jak kontroluje to, żeby nie pokazac ich zbyt wiele.
	
Ten trzeci punkt, to właśnie ta sfera, na której najbardziej skupia się bieżąca solucja.	
Projekty, które planuje w niej umieścić bedą mocno uproszczone, ale nie pozbawione jakiegokolwiek sensu. Poprostu nie chcę aby dopieszczanie i nadmiar kodu przysłaniał i komplikował istotę głównego przekazu.
Mogą pojawić się więc tu dobre przykłady złych przykładów :) Czasem łamiące pewne fundamentalne zasady bezpieczeństwa. Ale będzie to w pełni świadome, a zagrożenia wynikające z takich uproszczeń postaram się szczegółowo objasniać.
	
ASP.NET to dość szeroki zbiór podsystemów. Pomijając ewolucję samego języka C# i .Net Framework 4.x/Net Core/.NET , mamy tu doczynienia z takimi technologiami jak Web Forms, Web Pages/Razor Pages, MVC, Web Api i WCF.
Postaram się wrzucać tu projekty w każdej z nich ale z racji, że ostatnio musiałem przypomnieć sobie działanie tej najstarszej, to pierwszy projekt bazował będzie na Web Forms.
Podstawowe zasady są jednak bardzo podobne, niezależnie od wybranego podsystemu. Web Forms ma też dość niski próg wejścia i pozwala mocno odciąć się choćby od js, co z kolei pozwala skupić uwagę na istocie rzeczy.
        
Zgodnie z przyjetą konwencją, zamierzam o wszystkim opowiadać dość mocno łopatologicznie. Językiem prostym, tłumacząc niemal kazdą linię kodu.
Miłego ...
