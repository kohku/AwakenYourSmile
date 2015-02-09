<?xml version="1.0" encoding="iso-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html xmlns="http://www.w3.org/1999/xhtml">
      <head>
        <title>
          Confirmación de Cita
        </title>
      </head>
      <body>
        Hola <xsl:value-of select="FirstName"/>&nbsp;<xsl:value-of select="LastName"/>, desafortunadamente no pudimos confirmar tu cita del día.

      Por favor intenta con otro horaro o fecha distinta.

      También puedes llamarnos al 01 452 519 2690

      Gracias por confiar en nosotros.

      El equipo de Despierta tu sonrisa.
    </body>
    </html>
  </xsl:template>
</xsl:stylesheet>