When the application first runs, it must learn from the user what action he wants to perform. These are the basic transactions that can be made via ATM. Withdrawing money, depositing money, making payments, etc. It can be expanded optionally. First of all, it must be ensured that the user logging into the ATM is a registered user in the system.

There should also be an end of day option in the application. When you want to receive end-of-day data, logs of transactions made during the day and logs of incorrect login attempts that may be fraudulent should be displayed. It should be written to a file named EOD_Date (in DDMMYYY format).txt at a specified location on the same client's computer.

Techniques to use:

Writing to File
Reading from File
The transaction list is available as pre-defined.
---------------------------
Uygulama ilk çalıştığında kullanıcıdan yapmak istediği işlemi öğrenmelidir. Bunlar ATM üzerinden yapılabilecek temel işlemledir. Para çekme, para yatırma, ödeme yapma vs.. İsteğe bağlı olarak genişletilebilir. Öncelikle ATM ye giriş yapan kullanıcın sistemde kayıtlı bir kullanıcı olduğundan emin olunmalıdır.

Uygulamada bir de gün sonu seçeneği olmalıdır. Gün sonu alınmak istendiğinde, gün içerisinde yapılan transactionların logları ve fraud olabilecek yani hatalı giriş denemeleri log gösterilmelidir. Aynı client'ın bilgisayarında belirlenen bir lokasyona EOD_Tarih(DDMMYYY formatında).txt adında bir dosyaya yazılmalıdır.

Kullanılması gereken teknikler:

Dosyaya Yazma
Dosyadan Okuma
İşlem listesi pre-defined olarak kullanılabilir.
