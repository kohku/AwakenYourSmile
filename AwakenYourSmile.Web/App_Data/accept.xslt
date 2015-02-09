<?xml version="1.0" encoding="iso-8859-1"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:ms="urn:schemas-microsoft-com:xslt"
                xmlns:dt="urn:schemas-microsoft-com:datatypes">
  <xsl:template match="/">
    <html xmlns="http://www.w3.org/1999/xhtml">
      <head>
        <title>
          Confirmación de Cita
        </title>
      </head>
      <body>
        Hola <xsl:value-of select="Appointment/FirstName"/>&#160;<xsl:value-of select="Appointment/LastName"/>, hemos confirmado tu cita del día <xsl:value-of select="ms:format-date(Appointment/AppointmentDate, 'MMM dd, yyyy')"/>.

        Gracias por confiar en nosotros.

        El equipo de Despierta tu sonrisa.
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>