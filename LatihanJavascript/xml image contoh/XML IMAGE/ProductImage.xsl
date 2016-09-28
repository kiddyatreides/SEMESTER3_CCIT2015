<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
<html>
<body>
MENU MAKANAN
  <table> 
  <xsl:for-each select="PRODUCTDETAILS/PRODUCT">
    <tr><td><xsl:value-of select="PRODNAME"/></td>
      </tr>
      <tr>
        <td><img>
         <xsl:attribute name="src">
            <xsl:value-of select="GAMBAR"/>
          </xsl:attribute>
          <xsl:attribute name="height">
            <xsl:value-of select="GAMBAR/@HEIGHT"/>
          </xsl:attribute>
          <xsl:attribute name="width">
            <xsl:value-of select="GAMBAR/@WIDTH"/>
          </xsl:attribute>
        </img></td>
        </tr>
        <tr><td><xsl:value-of select="DESC"/></td></tr>
      <tr><td><xsl:value-of select="PRICE"/></td></tr>
      <tr><td><a>
      <xsl:attribute name="href">
            <xsl:value-of select="LINK"/>
          </xsl:attribute><xsl:value-of select="LINK"/></a></td></tr>
    
  </xsl:for-each>
  </table>
</body>
</html>
</xsl:template>
</xsl:stylesheet>