<?xml version="1.0" encoding="UTF-8"?>
<xsl-stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:template match="AUTHOR">
  <xsl:value-of select="FIRSTNAME"/>
  <xsl:value-of select="LASTNAME"/>
  <xsl:if test="position()!=last()">, </xsl:if>
</xsl:template>
  
<xsl:template match="/">
  <HTML>
    <HEAD><TITLE>BOOKS AT CYBERSHOP</TITLE></HEAD>
    <BODY>
      <H1>BOOKS AT CYBERSHOPPE</H1>
      <TABLE BORDER="10" CELLSPACING="10" CELLPADDING="10">
        <THEAD ALIGN="CENTER" BGCOLOR="SILVER">
          <TH> BOOK ID </TH>
          <TH> TITLE </TH>
          <TH> RATE </TH>
          <TH> AUTHOR(S) </TH>
        </THEAD>
        <xsl:for-each select="BOOKS/BOOK">
          <TR>
            <TD>
              <font color="red">
                <xsl:value-of select="@BOOKID"/>
              </font>
            </TD>
            <TD>
                <xsl:value-of select="TITLE"/>
            </TD>
            <TD>
              <xsl:value-of select="RATE"/>
            </TD>
            <TD>
              <xsl:apply-templates select="AUTHOR"/>
            </TD>
          </TR>
        </xsl:for-each>
      </TABLE>
    </BODY>
</HTML>
</xsl:template>
</xsl-stylesheet>
  