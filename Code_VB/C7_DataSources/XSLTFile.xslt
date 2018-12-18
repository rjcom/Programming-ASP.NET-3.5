<?xml version="1.0"?>
<xsl:stylesheet
  version="1.0"
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
  xmlns:xsd="http://www.w3.org/2001/XMLSchema"
  xmlns:atom="http://www.w3.org/2005/Atom"
  xmlns:msxsl="urn:schemas-microsoft-com:xslt">
  <xsl:strip-space elements="*"/>
  <xsl:output method="xml"
              omit-xml-declaration="yes"
              indent="yes"
              standalone="yes" />
  <xsl:template match="/">
    <xsl:for-each select="atom:feed">
      <xsl:element name="feed">
        <xsl:for-each select="atom:entry">
          <xsl:element name="entry">
            <xsl:attribute name="title">
              <xsl:value-of select="atom:title"/>
            </xsl:attribute>
            <xsl:attribute name="updated">
              <xsl:value-of select="atom:updated"/>
            </xsl:attribute>
          </xsl:element>
        </xsl:for-each>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>

