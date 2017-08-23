using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	
	public bool dildac;
	public bool sranje;
	public bool kiko;
	public bool lule;
	public bool santro;
	public bool alen;
	public bool cetka;
	public bool pendrek;
	
	
	private enum States {pocetni, hodnik, hodnik_0, hodnik_1, hodnik_2, hodnik_3, dnevna, dnevna_0, dnevna_1, dnevna_2, dnevna_3, dnevna_4, tv, kuhinja, lule_soba, lule_soba_0, lule_soba_1, lule_soba_2, kiko_soba, kiko_soba_0, kiko_soba_1,kiko_soba_2, kiko_soba_3, komp, wc, wc_0, kuhinja_0, kuhinja_1, kuhinja_2, spajz, balkon, balkon_0 , balkon_1, balkon_2, balkon_3, kraj };
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.pocetni;
		dildac = false;
		sranje = false;
		kiko = false;
		lule = false;
		santro = false;
		alen = false;
		cetka = false;
		pendrek = true;
					
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		print (dildac);
		print (sranje);
		print (lule);
		print (kiko);
		print (santro);
		print (alen);
		
		if(myState == States.pocetni)			{state_pocetni();} 
		else if(myState == States.hodnik)		{state_hodnik();}
		else if(myState == States.hodnik_0)		{state_hodnik_0();}
		else if(myState == States.hodnik_1)		{state_hodnik_1();}
		else if(myState == States.hodnik_2)		{state_hodnik_2();}
		else if(myState == States.hodnik_3)		{state_hodnik_3();}
		else if (myState == States.dnevna)		{state_dnevna();}
		else if (myState == States.dnevna_0)	{state_dnevna_0();}
		else if (myState == States.dnevna_1)	{state_dnevna_1();}
		else if (myState == States.dnevna_2)	{state_dnevna_2();}
		else if (myState == States.dnevna_3)	{state_dnevna_3();}
		else if (myState == States.dnevna_4)	{state_dnevna_4();}
		else if (myState == States.tv)			{state_tv();}
		else if (myState == States.kiko_soba)	{state_kiko_soba();}
		else if (myState == States.kiko_soba_0)	{state_kiko_soba_0();}
		else if (myState == States.kiko_soba_1)	{state_kiko_soba_1();}
		else if (myState == States.kiko_soba_2)	{state_kiko_soba_2();}
		else if (myState == States.kiko_soba_3)	{state_kiko_soba_3();}
		else if (myState == States.komp)		{state_komp();}
		else if (myState == States.lule_soba)	{state_lule_soba();}
		else if (myState == States.lule_soba_0)	{state_lule_soba_0();}
		else if (myState == States.lule_soba_1)	{state_lule_soba_1();}
		else if (myState == States.lule_soba_2)	{state_lule_soba_2();}
		else if (myState == States.kuhinja)		{state_kuhinja();}
		else if (myState == States.kuhinja_0)	{state_kuhinja_0();}
		else if (myState == States.kuhinja_1)	{state_kuhinja_1();}
		else if (myState == States.kuhinja_2)	{state_kuhinja_2();}
		else if (myState == States.wc)			{state_wc();}
		else if (myState == States.wc_0)		{state_wc_0();}
		else if (myState == States.balkon)		{state_balkon();}
		else if (myState == States.balkon_0)		{state_balkon_0();}
		else if (myState == States.balkon_1)		{state_balkon_1();}
		else if (myState == States.balkon_2)		{state_balkon_2();}
		
		else if (myState == States.kraj)		{state_kraj();}
	}
	
	void state_pocetni (){
		text.text = "Nakon što je HDZ dobio izbore, koalirao je s SDP-om i količina gluposti izazvala je rijetku mutaciju. Svi su postali zombiji." +
					"Brzo si potrčao iz svog stana i krenuo prema jedinom utočištu... Primorska 27!\n\n" + 
					"Pritsni Enter za dalje";
		if(Input.GetKeyDown(KeyCode.Return)){
			myState = States.hodnik;
			}
	}
	
	void state_hodnik() {
		text.text = "Nalaziš se u ogromnom stanu, stojiš u hodniku, " +
					"lijevo od tebe je dnevna soba, desno je kuhinja. " + 
					"Ispred tebe su vrata oblijepljena posterima. U stanu je tiho, " +
					"nešto tu smrdi. Nije ti jasno što se dešava. " +
					"Moraš preživjeti i spasiti drugove! \n\n" + 
					"Stisni tipak D da ideš u dnevnu, K da ideš u kuhinju i N da probaš ući u sobu s posterima";
		if(Input.GetKeyDown(KeyCode.D))			{myState = States.dnevna;} 
		else if (Input.GetKeyDown(KeyCode.K))	{myState = States.kuhinja;} 
		else if (Input.GetKeyDown(KeyCode.N))	{myState = States.lule_soba;}
		}
		
	void state_dnevna() {
		text.text = "Ulaziš u dnevnu. Nema nikoga, jaja su ti se stisla ko kikiriki. " +
					"Znojis se. Napeto je. Trosjed di Alen spava je poderan. U kutu sobe vidiš komp. " + 
					"Lijevo od njega je TV. Desno od ulaza je Kikina i Santrova soba. Vrata su zatvorena. " +
					"Upravo te malo stišće u stomaku i trebaš prdnut. " +
					"\n\n" + 
					"Opali po tipki P da se isprdiš ko životinja, N da zadržiš prdac u sebi!";
		if(Input.GetKeyDown(KeyCode.P))			{myState = States.dnevna_0;} 
		else if (Input.GetKeyDown(KeyCode.N))	{myState = States.dnevna_1;}
	}
	
	void state_dnevna_0() {
		text.text = "Taman si se namjestio i puštaš ga. Topao zrak ti razdire guzove. " +
					"Gromada od prdeža tek dolazi. Razvaljuješ ga i čuješ siktanje iza sebe. " + 
					"Okrećeš se. Prdežom si razneso zombija po cijeloj dnevnoj. Malo smrdi po truljavom " +
					"al boli te kurac, sad ti je lakše. " +
					"\n\n" + 
					"Sabij T za TV, K za komp, S za Kikinu i Santrovu sobu ili  R da se vratiš u hodnik.";
		if(Input.GetKeyDown(KeyCode.T))			{myState = States.tv;} 
		else if (Input.GetKeyDown(KeyCode.K))	{myState = States.komp;}
		else if (Input.GetKeyDown(KeyCode.S))	{myState = States.kiko_soba;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.hodnik;}
	}
	
	
	void state_dnevna_1() {
		text.text = "Zadržavaš prdac i čuješ siktanje iza sebe. Zombij se zaleti i ugrize te za muda. " +
			"Padneš vrišeći i jebeš mu mater. Ugrize te još jedanput i pregrize ti crijevo. " + 
				"Prdež akumulira i izleti kroz rupu raznese tebe na pola, a zombija na trećine. " +
				"Kakav čovjek zadržava prdac? Pokušaj ponovo!" +
				"\n\n" + 
				"Stisni enter i probaj prdnut slijedeći put!";
		if(Input.GetKeyDown(KeyCode.Return))	{Start();}
	}
	
	void state_dnevna_2() {
		text.text = "Znojis se. Napeto je. Trosjed di Alen spava je poderan. U kutu sobe vidiš komp. " + 
			"Lijevo od njega je TV. Desno od ulaza je Kikina i Santrova soba. Vrata su zatvorena. " +
				"\n\n" + 
				"Sabij T za TV, K za komp, S za Kikinu i Santrovu sobu ili  R da se vratiš u hodnik.";
		if(Input.GetKeyDown(KeyCode.T))			{myState = States.tv;} 
		else if (Input.GetKeyDown(KeyCode.K))	{myState = States.komp;}
		else if (Input.GetKeyDown(KeyCode.S))	{myState = States.kiko_soba;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.hodnik;}
		}
	
	void state_tv() {
		text.text = "Upališ tv i vidiš standardno preseravanje. Hitne vijesti i gluposti ti iziritiraju " +
					"stomak. Počne ti se srat, pa brzo gasiš " + 
					"\n\n" + 
					"Stisni R i ugasi TV";
		sranje = true;
		if(Input.GetKeyDown(KeyCode.R))	{myState = States.dnevna_2;}
	
	}
	
	void state_komp() {
		text.text = "Upališ komp i počnu se vrtit klasike. Tri u jednom, Dugi crni petak i Brokeback mountain. " + 
					"Na fotelji se nalazi dildo na kojeg si slučajno sjeo. Uzimaš ga sebi, za svaki slučaj.\n\n" + 
					"Stisni R i odi stajat nasred sobe";
		dildac = true;
		if(Input.GetKeyDown(KeyCode.R))	{myState = States.dnevna_2;}
	}
	
	void state_kiko_soba() {
		text.text = "U strahu otvaraš vrata... Pff dobro je, ne čeka te nikakvo iznenađenje. Soba je zamračena. " + 
					"Kiko spava. Odmah znaš da je negdje oko 2 popodne. Moraš ga probudit što prije!\n\n" + 
					"Stisni D da naglo povučeš deku da se zasere, stisni S da ga zvizneš šakom pod rebro.";
		if(Input.GetKeyDown(KeyCode.D))	{myState = States.kiko_soba_0;}
		if(Input.GetKeyDown(KeyCode.S))	{myState = States.kiko_soba_1;}
	}
	
	void state_kiko_soba_0() {
		text.text = "Naglo povlačiš deku, iskače kikina kita i svrši ti u oko. Oslijepio si.  " + 
					"Bravo debilu. Kakav si ti to frend. Sad se snađi jer Kiko još spava.\n\n" + 
					"Stisni U da ga udariš ili R da istrčiš van iz sobe.";
		if(Input.GetKeyDown(KeyCode.U))	{myState = States.kiko_soba_2;}
		if(Input.GetKeyDown(KeyCode.R))	{myState = States.kiko_soba_3;}
	}
	
	void state_kiko_soba_1() {
		text.text = "Udaraš Kiku u rebro i Kiko se budi. Pitaš ga di su ostali međutim Kiko nezna. " + 
					"Objašnjavaš mu situaciju ali on se okreće na drugu stranu i ide spavat. \n\n" + 
					"Stisni D da povedeš Kiku sa sobom, stisni N za ko ga jebe.";
		if(Input.GetKeyDown(KeyCode.D))	{myState = States.dnevna_3;}
		if(Input.GetKeyDown(KeyCode.N))	{myState = States.dnevna_4;}
		
		
	}
	
	void state_kiko_soba_2() {
		text.text = "Oslijepljen hoćeš udarit Kiku ali opet rukom hvataš kitu. " + 
					"Ruka ti se otopi i iskrvariš na smrt. Mislim da imaš pederske sklonosti. Probaj opet.\n\n" + 
					"Stisni Enter da probaš opet.";
		if(Input.GetKeyDown(KeyCode.Return))	{Start();}
		
	}
	void state_kiko_soba_3() {
		text.text = "Istrčavaš van iz sobe ko debil. S obzirom da si jebeno oslijepio udaraš zapinješ za Alenov " + 
					"trosjed i udaraš glavom o ormar. Glava ti je upravo pukla ko jebeno jaje. \n\n" + 
					"Stisni Enter za drugi puta ću pametnije.";
					if(Input.GetKeyDown(KeyCode.Return))	{Start();}
		
	}
	
	void state_dnevna_3() {
		if(dildac == true){
		text.text = "Natjeraš Kiku da se ustane i krene s tobom. Kiko se obuče nabrzinu i spremni ste. " + 
					"Izlazite iz sobe, najedanput na vas nasrće zombij. \n\n" + 
					"Stisni K da podmetneš Kiku, Z da žrtvuješ sebe " +
					"ili D da upotrijebiš dildač."; }
		else {
				text.text = "Natjeraš Kiku da se ustane i krene s tobom. Kiko se obuče nabrzinu i spremni ste. " + 
				"Izlazite iz sobe, najedanput na vas nasrće zombij. \n\n" + 
				"Stisni K da podmetneš Kiku, Z da žrtvuješ sebe." ;		
		}
		
		kiko = true;
		if(Input.GetKeyDown(KeyCode.D))	{myState = States.hodnik_0;}
		if(Input.GetKeyDown(KeyCode.K))	{myState = States.hodnik_1;}
		if(Input.GetKeyDown(KeyCode.Z))	{myState = States.hodnik_2;}
		}
		
	void state_dnevna_4() {
		if(dildac == true){
			text.text = "Kiko ostaje spavat. Ko ga jebe. Ideš spasit sebe. " + 
						"Izlaziš iz sobe, najedanput na tebe nasrće zombij. \n\n" + 
						"Stisni Z da žrtvuješ sebe " +
						"ili D da upotrijebiš dildač."; }
		else {
			text.text = "Kiko ostaje spavat. Ko ga jebe. Ideš spasit sebe. " + 
						"Izlaziš iz sobe, najedanput na tebe nasrće zombij. \n\n" + 
						"Stisni Z da žrtvuješ sebe "; }		
		
		
		if(Input.GetKeyDown(KeyCode.D))	{myState = States.hodnik_0;}
		if(Input.GetKeyDown(KeyCode.Z))	{myState = States.hodnik_2;}
	}
		
	void state_hodnik_0() {
		text.text = "Mlatneš zombija dildom po glavi. Dildo je fala kurcu elastičan i s dva kraja tak da ga ima metar. " + 
					"Zombijeva glava se raspadne na pola i on padne na pod nešto mumljajući. Ti ga još šutneš na podu. \n\n" + 
					"Stisni H za hodnik";
		if(Input.GetKeyDown(KeyCode.H))	{myState = States.hodnik_3;}
	}
		
	void state_hodnik_2() {
		text.text = "Žrtvuješ sebe za Kiku i zombij te proždire. Koji kurac onak? " + 
					"Jel kontaš da trebaš preživit ovo sranje. \n\n" + 
					"Stisni Enter pa probaj opet.";
		if(Input.GetKeyDown(KeyCode.Return))	{Start();}
		}
		
	void state_hodnik_1() {
		text.text = "Hvataš Kiku i bacaš ga na zombija. Obadvojica padnu kroz prozor i krepaju. " + 
					"Malo si ispo kreten, al bar si živ. \n\n" + 
					"Stisni H za hodnik";
					
		kiko = false;
		if(Input.GetKeyDown(KeyCode.H))	{myState = States.hodnik_3;}
	}
	
	void state_hodnik_3() {
		text.text = "Nazad si u hodniku. Ispred tebe je soba oblijepljena posterima. Desno je kuhinja" + 
					"\n\n" + 
					"Stisni S za sobu, K za kuhinju.";
		if(Input.GetKeyDown(KeyCode.S))	{myState = States.lule_soba;}
		if(Input.GetKeyDown(KeyCode.K)) {myState = States.kuhinja;}
	}
	
	void state_lule_soba() {
		if(dildac == true && kiko == false){
		text.text = "Ulaziš polako u sobu s posterima. To je Luletova soba. Lule čuči u kutu i plače. " + 
					"Brzo kreneš prema njemu međutim Lule se diže i skače na tebe. Ima žute oči. Počeo se pretvarat u zombija. \n\n" + 
					"Stisni D da ga razvališ dildačem, stisni V da vrištiš ko pička. ";
					}
		if(kiko == true && dildac == false){
			text.text = "Ulaziš polako u sobu s posterima. To je Luletova soba. Lule čuči u kutu i plače. " + 
						"Brzo kreneš prema njemu međutim Lule se diže i skače na tebe. Ima žute oči. Počeo se pretvarat u zombija. \n\n" + 
						"Stisni K da pošalješ Kiku na njega, stisni V da vrištiš ko pička. ";
		}
		if((kiko == true) && (dildac == true)){
			text.text = "Ulaziš polako u sobu s posterima. To je Luletova soba. Lule čuči u kutu i plače. " + 
						"Brzo kreneš prema njemu međutim Lule se diže i skače na tebe. Ima žute oči. Počeo se pretvarat u zombija. \n\n" + 
						"Stisni K da pošalješ Kiku na njega, stisni D da ga razvališ dildačem ili stisni V da vrištiš ko pička. ";
		}
		else {
			text.text = "Ulaziš polako u sobu s posterima. To je Luletova soba. Lule čuči u kutu i plače. " + 
						"Brzo kreneš prema njemu međutim Lule se diže i skače na tebe. Ima žute oči. Počeo se pretvarat u zombija. \n\n" + 
						"Stisni V da vrištiš ko pička. ";
						}
		if(Input.GetKeyDown(KeyCode.D))	{myState = States.lule_soba_0;}
		if(Input.GetKeyDown(KeyCode.V))	{myState = States.lule_soba_1;}
		if(Input.GetKeyDown(KeyCode.K))	{myState = States.lule_soba_2;}
		
	}
	
	void state_lule_soba_0() {
			text.text = "Bacaš dildo na Luleta ali on ga proguta u jednom gutljaju i otkine ti muda. " + 
						"Krepo si zato što si govno od frenda. \n\n" + 
						"Stisni Enter da počneš ispočetka. ";
		if(Input.GetKeyDown(KeyCode.Return))	{Start();}
	}
	
	void state_lule_soba_1() {
		if(dildac == false){
			text.text = "Vrisneš ko pička i izletiš nazad u hodnik i zalupiš vratima. " + 
						"Koji ćeš sad kurac? \n\n" + 
						"Stisni D za dnevni, S za sobu i K za kuhinju. ";
					}
		else {
			text.text = "Vrisneš ko pička i izletiš nazad u hodnik i zalupiš vratima. " + 
						"Koji ćeš sad kurac? \n\n" + 
						"Stisni S za sobu i K za kuhinju. ";
		}
		if(Input.GetKeyDown(KeyCode.D))	{myState = States.dnevna;}
		if(Input.GetKeyDown(KeyCode.S))	{myState = States.lule_soba;}
		if(Input.GetKeyDown(KeyCode.K))	{myState = States.kuhinja;}
	}
	
	void state_lule_soba_2() {
			text.text = "Kiko istrčava prema Luletu i u trku mu podrigne u facu. Lule dolazi sebi i odzombljava se. " + 
						"Jebeno, nastavljas ih dalje izvlačit. Izlazite u hodnik. \n\n" + 
						"Stisni K za kuhinju. ";
		lule = true;
		if(Input.GetKeyDown(KeyCode.K))	{myState = States.kuhinja;}
	}
	
	void state_kuhinja() {
		if(sranje == true){
			text.text = "Trčiš hodnikom. Ali fak. Gledo si jebeni teve i prosralo te. " + 
						"Sva sreća na lievo je wc. Ulaziš u wc i jebeno se prestraviš. Zombij sjedi na školjci." + 
						"Fak šta ćeš sad?  \n\n" +
						"Stisni N da ga udariš nogom ili P da prdneš u njega."; }
		else {
			text.text = "Trčiš kroz hodnik i dolaziš u kuhinju. S lijeve strane se nešto miče i gmiže po podu. Ispred tebe je špajz " + 
						" \n\n" + 
						"Stisni L da pogledaš bliže kaj se miče ili S za špajz "; }		
		
		
		if(Input.GetKeyDown(KeyCode.N))	{myState = States.wc;}
		if(Input.GetKeyDown(KeyCode.P))	{myState = States.wc_0;}
		if(Input.GetKeyDown(KeyCode.L))	{myState = States.kuhinja_0;}
		if(Input.GetKeyDown(KeyCode.S))	{myState = States.spajz;}
	}
	
	void state_wc() {
		text.text = "Udaraš ga nogom. On se miče. Jebote to je Santro. Blijed je ko krpa. Zasro se zombija i onesvijestio se. " + 
					"Daješ mu umjetno disanje i nizozemsko kormilo i on dolazi sebi. Usput se posereš. Izlazite van. Grabiš sa sobom četku za wc. Uvijek ti može dobro doć. \n\n" + 
					"Stisni H za povratak u hodnik!";
		sranje = false;
		santro = true;
		cetka = true;
		if(Input.GetKeyDown(KeyCode.H))	{myState = States.kuhinja;}
	}
	
	void state_wc_0() {
		text.text = "Na guziš se i prdneš. Prdež razvali pola wc-a. Usput se i posereš tak da ti je lakše. Ali kurac, to je bio Santro. " + 
					"Ubio si ga. Idiote. Ništa, brzo bježi ko da se niš nije desilo. \n\n" + 
					"Stisni H za povratak u hodnik!";
		sranje = false;
		cetka = true;
		if(Input.GetKeyDown(KeyCode.H))	{myState = States.kuhinja;}
	}
	
	void state_spajz() {
		text.text = "Špajz je hladan i mali. Unutra je krevet i polica. Na polici je Luletov pendrek. Jebeno. " + 
					"Sad možeš glumit jebenog švarcnegera. \n\n" + 
					"Stisni K za povratak u kuhinju!";
		pendrek = true;
		if(Input.GetKeyDown(KeyCode.H))	{myState = States.kuhinja;}
	}
	
	void state_kuhinja_0() {
		if(lule == true){
			text.text = "Pomičeš se polako na lijevo i oprezno očekuješ šta će iskočit. AAAAAA. Ubili su Alena. " + 
						"Leži na podu i trese se a iz usta mu curi krv. Čekaj, koji kurac. To nije krv, to je marmelada. " + 
						"On se guši. Napravi nešto.  \n\n" +
						"Stisni H za Heimlichov hvat, L da Lule napravi Hemilichov hvat"; }
		else {
			text.text = "Pomičeš se polako na lijevo i oprezno očekuješ šta će iskočit. AAAAAA. Ubili su Alena. " + 
						"Leži na podu i trese se a iz usta mu curi krv. Čekaj, koji kurac. To nije krv, to je marmelada. " + 
						"On se guši. Napravi nešto.  \n\n" +
						"Stisni H za Heimlichov hvat"; }
		
		
		if(Input.GetKeyDown(KeyCode.H))	{myState = States.kuhinja_1;}
		if(Input.GetKeyDown(KeyCode.L))	{myState = States.kuhinja_2;}
		
	}
	
	void state_kuhinja_1() {
		text.text = "Otkud ti znaš napravit Heimlichov hvat? Počneš se preseravat i ugušiš Alena. " + 
					"UBIJ SE! Kladim se da gi ni izdrkat nemoš sam. Okrećeš se. Iza tebe je roj zombija, brzo bježiš na balkon. \n\n" + 
					"Stisni B da pobjegneš ko pička!";
		
		if(Input.GetKeyDown(KeyCode.B))	{myState = States.balkon;}
	}
	void state_kuhinja_2() {
		text.text = "Lule skače na Alena i prelomi ga jednim okretom. Alen je Živ. Jedini korisni kurac što je Lule naučio na akademiji. " + 
					"Okrećeš se. Iza tebe je roj zombija, brzo bježite na balkon. \n\n" + 
					"Stisni B da pobjegneš ko pička!";
		alen = true;
		if(Input.GetKeyDown(KeyCode.B))	{myState = States.balkon;}
	}
	
	void state_balkon() {
		if(lule == true && kiko == true){
			text.text = "Opkolili su vas. Jedini put van je da poskačete svi dolje. Moraš smislit plan." + 
						" \n\n" +
						"Stisni A za to da je Lule čuva vrata a Kiko mu drži potporu ili B  " +
						"za to da je Kiko na vratima a Lule odozada"; }
		if(lule == true){
			text.text = "Opkolili su vas. Jedini put van je da poskačete svi dolje. Moraš smislit plan." + 
					"Pošto si sjebo i nisi sačuvao Kiku moraš birat oćeš branit vrata il bit podrška.\n\n" +
					"Stisni C za to da Lule čuva" ; }
		else {
					text.text = "Opkolili su te. Jedini put van je da skočiš dolje. Zaletio si se i preskačeš. " + 
								"Sada si na sigurnom, brao!.\n\n" +
								"Stisni Enter za statistiku!  "; }
		
		
		if(Input.GetKeyDown(KeyCode.A))	{myState = States.balkon_0;}
		if(Input.GetKeyDown(KeyCode.B))	{myState = States.balkon_1;}
		if(Input.GetKeyDown(KeyCode.C))	{myState = States.balkon_2;}
		if(Input.GetKeyDown(KeyCode.Return))	{myState = States.kraj;}
		}
		
	void state_balkon_0() {
		if(pendrek == true){
			text.text = "Lule je na vratima i daješ mu pendrek. Prebacuje se u murjak mod i sabije sve i jednog zombija." + 
						"To je to. Skačete s balkona susjedi na balkon i bježite u sigurno... \n\n" +
						"Stisni Enter za statistiku  "; }
		else{
			text.text = "Lule je na vratima. Rukom zagrabi al ga zombiji dohvate. Kiko podrigne i odbaci ih u kuhinju." + 
						"Taman imate dosta vremena za pobjeć. To je to. Skačete s balkona susjedi na balkon i bježite u sigurno... \n\n" +
						"Stisni Enter za statistiku  ";
						lule = false;}

		
		if(Input.GetKeyDown(KeyCode.Return))	{myState = States.kraj;}
		}
		
	void state_balkon_1() {
		if(pendrek == true){
			text.text = "Kiko je na vratima. Ali ne uspjeva odbit sve zombije. Daješ pendrek Luletu. Prebacuje se u murjak mod i sabije sve i jednog zombija." + 
				"To je to. Skačete s balkona susjedi na balkon i bježite u sigurno... \n\n" +
					"Stisni Enter za statistiku  "; 
					kiko = false;
					}
		else{
			text.text = "Kiko je na vratima.Zombiji dohvate i njega i Luleta." + 
						"Svi ste u kurcu i pogibate. \n\n" +
						"Stisni P za opet  ";}
		
		
		if(Input.GetKeyDown(KeyCode.Return))	{myState = States.kraj;}
		if(Input.GetKeyDown(KeyCode.P))			{Start();}
	}
		
	void state_balkon_2() {
		if(pendrek == true){
			text.text = "Dobacuješ pendrek Luletu i on samlati sve zombije.Skačete kroz balkon." + 
						"Jebena si legenda \n\n" +
						"Pritsni Enter za statistiku! "; }
		else{
			text.text = "Lule je na vratima. Rukom zagrabi al ga zombiji dohvate. " + 
						"Dohvate i tebe. Krepavaš dok ti žvaču đigeru. \n\n" +
						"Stisni P za ponovnu igru  ";
			}
		
		if(Input.GetKeyDown(KeyCode.Return))	{myState = States.kraj;}
		if(Input.GetKeyDown(KeyCode.P))			{Start();}
		
	}
	
	void state_kraj() {
		text.text = "Svastistika: \n\n" + 
					"Alen = "+ alen + "\nKiko = "+kiko+"\nLule = "+lule+"\nSantro = "+santro+
					"\n\nStisni Enter za ponovno prčenje!";
		if(Input.GetKeyDown(KeyCode.Return))	{Start();}
	}
	

}
