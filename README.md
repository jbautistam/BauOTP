# BauOtp

Aplicaci�n WPF ejemplo de uso de la librer�a [OneTimePassword](https://github.com/jbautistam/OneTimePassword).

La autenticaci�n de un solo uso (OTP) es un m�todo de autenticaci�n multifactor (MFA) que proporciona 
una capa adicional de seguridad a las cuentas de usuario.

La pantalla principal nos permite mantener las diferentes cuantas con autenticaci�n MFA:

![Pantalla inicial](/images/main-window.png)

Al abrir la pantalla de administraci�n de cuentas, nos permite ver los c�digos generados para esa configuraci�n
tanto con TOTP ([RFC 6238](http://tools.ietf.org/html/rfc6238)) como con HOTP ([RFC 4226](http://tools.ietf.org/html/rfc4226))
utilizando un contador:

![Pantalla inicial](/images/otp-generation.png)