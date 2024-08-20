# BauOtp

Aplicación WPF ejemplo de uso de la librería [OneTimePassword](https://github.com/jbautistam/OneTimePassword).

La autenticación de un solo uso (OTP) es un método de autenticación multifactor (MFA) que proporciona 
una capa adicional de seguridad a las cuentas de usuario.

La pantalla principal nos permite mantener las diferentes cuantas con autenticación MFA:

![Pantalla inicial](/images/main-window.png)

Al abrir la pantalla de administración de cuentas, nos permite ver los códigos generados para esa configuración
tanto con TOTP ([RFC 6238](http://tools.ietf.org/html/rfc6238)) como con HOTP ([RFC 4226](http://tools.ietf.org/html/rfc4226))
utilizando un contador:

![Pantalla inicial](/images/otp-generation.png)