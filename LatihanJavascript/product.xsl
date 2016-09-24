<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:template match="/">
<xsl:for-each select="PRODUCTNAME/PRODUCT">
<xsl:sort select="@PRODID" order="ascending"/>
<li>
  <xsl:text>Product ID : </xsl:text>
  <font color="red"><xsl:value-of select="@PRODID"/></font>
  <xsl:text> Product Name : </xsl:text>
  <font color="red"><xsl:apply-templates select="PRODUCTNAME"/></font>
  <xsl:text> Price Per Unit (In U. S $) : </xsl:text>
  <font color="red"><xsl:value-of select="PRICE"/></font>
</li>
</xsl:for-each>
</xsl:template>
</xsl:stylesheet>
