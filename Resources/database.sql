-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: system
-- ------------------------------------------------------
-- Server version	8.3.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `account`
--

DROP TABLE IF EXISTS `account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `account` (
  `AccountId` int NOT NULL,
  `UserName` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `FK_UserId_Account` varchar(45) NOT NULL,
  `ImageData` longblob,
  PRIMARY KEY (`AccountId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `account`
--

LOCK TABLES `account` WRITE;
/*!40000 ALTER TABLE `account` DISABLE KEYS */;
INSERT INTO `account` VALUES (1,'admin132','Admin12345678@','10-1-00231',_binary '‰PNG\r\n\Z\n\0\0\0\rIHDR\0\0\0\0\0\0\0\0\0Ã¦$\È\0\0\0sBIT\Û\áO\à\0\0\0	pHYs\0\0›¤\0\0›¤¾\nIf\0\0\0tEXtSoftware\0www.inkscape.org›\î<\Z\0\0\0PLTEÿÿÿ\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0#·\á\0\0\0ÿtRNS\0	\n\r\Z !\"#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~€‚ƒ„…†‡ˆ‰Š‹Œ‘’“”•–—˜™š›œŸ ¡¢£¤¥¦§¨©ª«¬­®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁ\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ë\Ì\Í\Î\Ï\Ğ\Ñ\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\Û\Ü\İ\Ş\ß\à\á\â\ã\ä\å\æ\ç\è\é\ê\ë\ì\í\î\ïğñòóôõö÷øùúûüış\ë\Ù5\0\0\Z%IDAT\íÁ€u\Ş7ğ\ï\Ü÷\ÌmN¦©Æš\n™JoD\Å\Z[¶\ÚM\Ê)\ÛÆ˜NB’v¥\âi2–Y\ÏÓ›\íd\ì&OK1)F/\ÏZlb«GM#\ÙMj±˜\Æ4˜\æ<s\ß\ß7aœ™\Ãı¿®\ßÿºşŸ\à\Zañn0|\Âô9—®Xó\é·\ä\î-,­©)-Ü›»e\ãŸ®Y±t\áœ\é†¸¥C|§¹¬Ç\çfÿ%{k\ë¡hkö_f?7¤\Çešj\ŞõW\Ïüi\Å\æJ6Jå–•¯?{_·xúhú\Ó\á¯}TÈ *úxÆ£İ›Â\Í\Û~\Ğ\ä÷·¨H`\Ûû¿\Ô\ŞC¢–ƒ_\É)£\Êr^\Ü† \Ş\ëGg~GK}—9úz/û\ÅÜ–öÁ!\Ú\â\Ği·\ÅÀ°§\ë¤l?m\åÏ\Ô\Õ\Ã\Í\î»€\"¼}3Vòt”\í§ ş\ìI]=0,5x\Ş>\n´o\Ş\à(ŠE|¯”b•½7(†2\áı\ß)¡p¥DÀP \É\İóQ%™ı\ÂaU\È\Ï\ß*¦FÎ»\Ã#X.™¸\Ú\ÉMm#¼w¾_M-\Õ,\í\ë…\Ñ8­\ÒvRc»§$Àh°\Ğ~\Ëü\Ô\\`\åÀ0\rqÑ„=t„ü\Ô8õuÅ«%tŒ²™\í`\ÔG·…~:Šqu\ä\é÷	è³^\ç1rj\Û\ãQ0\Î-z\Â>:Ø\Ôg9®€·ÿ\é(g\ÖdL] ÿ\Ép§ó\ÜE—\Ø=\Ê\ãd¡\í ‹\ä>\n\ã8\ÏĞ­t™­C=0J\Ú@Úã°„Et©E	0¢\Ó+\èZ\é\Ñp·”<ºZ^J\\,1‡®—“·j•I\ã™­\àF\Şq¥4~T:\Î\×é´F­u\à.\áÓªiœ zZ8\\$i3SlN‚[\Ä\Î\n\Ğ8M`V,\\¡ÿ\Zg´§?œ/>‹\ÆYe\Å\Ã\á\îú\Æ9ô…“Ed\Ğ8™‘p¬›hœ\×7\×Ã™B~SI£*Ÿ\n]²’F­ºÓ·€F\í\0g‰˜I£^fGÁA\ÚüƒF=}}%\ã\ÎB\ZõV|7œÁ“ \Ñ\0©8À…\Ëh4ĞŠ‹ ½N\Ûh4\Øöë¡¹\ä2\ZP>:óÍ \ÑH>h«ùZ\Z¶¶94uõv\ZA°ıjh\é\ÖB\ZAQx+4”\\E#Hª’¡I4‚hô\â›K#¨\æú ‘\Ø\Õ4‚lu,´‘°‰F\ĞmJ€&º\ä\ÓP ¿´Ğ½ˆ†E‰\Ğ@\Ï\ZŠ”ô‚x¿,§¡LE7 Š†BU÷B´!54”ªI`øi(±\ÆÒ°Àx5†%\Ò \Ò\Z™\ÆR\'ş\â]\ß|¾\êı·22\Şz\Õ\ç\ß\ì*öS\'\ã!\Î#\ÔÄ®fŒ¹½µ§ğ´¾}ÌŒvQA˜!~Ê·wşÃ£pNQ¿—òR Ê€\Z\nw kô5¨£kFg p5÷B_VQ´\Í\Ïuö ^<Ÿ\ÛLÑªú@Œ\ålÿŒnhn3öS°Š^¢{	Åª\Ì\ê\çCƒùúeUR¬’DˆĞ¥ˆR}ÿ\ìEh¤‹ıRu\0	ùj÷“‘‚\È\'vQ¨ü\Ø.ve\Ú>¢	‚\Ä÷È¿)Ó¦X\ØÌ·š\"mŠ òù–\"­öÁ^s)Q\ÙD‚,\ì\éRJ4¶šD‰–´†­S¢I°Q2\Ú\ŞŠô\ÙF’a›[«(N\å”(1¥’\âT\İ\n›\\]Hqşu”º\î[ŠSx5l\Ñ|;Å™\rÅ¢ß¢8Û›\Ã¾µ”¦|8,ğP¥Y\ëƒõfPš]K\\»‰\ÒdÀrÉ”f~4,ùgJ“‹u*£0\Ï\ÃB\ÏP˜òÎ°Ô…\Û(K\ÍpX\ê\ZÊ²\ãbXÈ³Œ²”\ß‹õ)£,+<°N\Ze9\Ğ–\ë~€²¤\Ã2w(\Ê\Î°Á5;)J\àX¤M!E\Ù\Ñ¶h¹ƒ¢·‡%\"şAQ\n\Ú\Ã&\í(Ê¦hXa&E)¹	¶¹©„¢¼	ô¥(UwÀFwTQ”AP\î’J[\r	P’- X\ÈJŠò[\Ø\ì·\åC\Ôú\rEy¶{…¢Œ‡R+)I¶ó}NIª:C¡ˆM”¤\è\nĞº’|	u2(\Ê@ˆpEù#”¹‹¢Ì€/Q”¾P$ş{J²¾	„ğ}NI\n\â¡F%9\Øb´.¤$YP¢?EA†S”şP v%ù\ÒA<Ù”dO,‚o%	ü¢töS’Yº¤\0%yÂ¼FII²ğÍ”d„‰\İKI6‡#¸¦Q”G \ÎPŠ2\rAÕ©š’|yşNIª;!ˆ¼\ë(J/”HQ\Öy<\ã(Ê§i5E‡ iUJQú@¤\Ş¥´‚%“¢l€P\Ù%A’HY\î…P})K\"‚\"$‡¢|\ëP!ÿ¤(9!†Ê’±~EYR\Ñy%/byr)J^4\Z/²¼Á¦R–t4ZBe\éÁ®¢,	h¬E”\åŸ\ísÊ²”Da‚hS˜$4Šgeñ_\n\Ñ\âª(\Ë\Zc(…Y	\á–P˜¡h„Ğ­f„Ha¶†¢\á¢051.¢’\Â<„ó\í 0ŸA¼5f‡\r5’Ò¤C¼TJ3\r\Ôd¥\é\rñzPš]M\Ğ0c(ME\Ä+¡4c\Ğ ‘y”f54ğWJ“‰†Gqƒ¢8\ã\Ğ\0\Ñ\'\Z\èBq\n¢Q(N\ZğTPœ	¨·\È}g´ğ\Å\Ù‰ú\ZEyşZXHyF¡<[(Ï‹\Ğ\ÂTÊ³Åƒú\éO†C\É¨?\êg-ºZ\èJÖ¢^ºS¢xh!–uG}dQ bh\"Ÿe¡\Úú)\Ğ:h\â\n\äo‹ºË Dƒ&–R¢\ÔY\\%Ê‚&\æS¢²8\ÔU*EšMü‰\"¥¢\Âò)\Òh\âEŠ”†ºH™¦A“(\Ó@\Ô\ÍJ\Ê4šø-eZ‰:IP¦1\Ğ\Äp\ÊH@]L¡P@÷Q¨)¨\ïn\n5šH¡v{q~})\Õh\"…Rõ\Åù-¥TOASª¥8¯5”j241RÕ´Àù¤R¬?@¿§X©8O.\Åzšxb\åzpnwP®\Ğ\Ä\Êu\Îm>\åZMdQ®ù8§ˆC”\ëch\âo”\ëP\Îe\0\ÛM|KÁ\à\\Ş¥`h!´Š‚½‹sˆ*¥d\×AWR²\Ò(œ\İ`Š6Z¸‹¢\r\Æ\ÙeQ´ÿ€\ÆQ´,œU\ÓrŠö´0‹¢•7\Å\Ù\ÜO\Ù>‡>¢l÷\ãl–P¶bh!Ÿ²-ÁY\\PI\á.‡šS¸\Êpf\Ã(]\n4ğ+J7g¶ˆ\ÒÍ…^§t‹pF¡Å”n4°•\Ò‡\âLn¦|WB¼V”\ïfœI:\åñR(_:\Îd=\å{\âÍ¥|\ëqñ\Ê÷}¤\ÛEùñ8\İ0\ê „\ë@\Ã\é2©ƒ\é.:\È\Äi<û©ƒ½^ˆòu°ßƒSu£~\Ñn¥º\áTi\ÔC&D{“zHÃ©²©‡²yz\È\Æ)bü\ÔÄƒ\ì\×Ô„?\'»ºX\rÁşJ]Ü“M¦.WA¬+j¨‹\É8Ù‡\Ô\Æˆõ\'j\ãCœ$´”Ú¨N€P—UR¥¡8Ñ\Ô\ÈLõj\äFœh,5Rq)DjVJŒÅ‰R\'\Ó!R:u²\'Ê£NJ\â Pl1u’‡´¡^~§^\Ú\à¸dê¥¢Ä¹¼”zI\Æq¯S3+ \Îÿ£f^\Çq_Q7ƒ \Ì]\Ô\ÍW¨å«¦nv5…(‘Û©›j\éHı¼Q¦R?q\ÌP\ê§ú:rU%õ3Ç¼@\r­õBŒ\Õ\Ô\Ğ8f9u”1&RG\Ëq\Ì\ê\È\ßBü¬†:Úƒ£â¨§¼Ÿ@„¸]\ÔS\èIM­\0!Ë¨©8\â	\ê\êYğ4uõ˜M]U\'\Âvİ«©«\Ù8\"‡\Ú\Ú\Ó\Z6k½‡\Ú\ÊÁ<e\Ô\×\æf°U³\Í\ÔW™‡µ¦\Î\Ö5…š®£\ÎZ\ã°$j\íl\ãû€ZK\ÂaPo<°‰gõö\0K£\æfÀ&3¨¹46—º{96y‰º›‹\Ã>¢ö2\Ã`¹°y\Ô\ŞG8l\'õ·2\Z‹ZNı\í\Ä|~:@N3X\ê\âl:€\ß \ras,\Ô\ê:B\0½\éy7\Â2v\Òzx˜Qù8,2²‚ñ0€©tŒEÀ1\èSÌ£sl»\Êu\ŞJ\ç˜`¤òq(6º’²\nÀ:\Ê\âK¡Ğ¥‹\é(\0ì¤³|2Šx\Ç¤³\ìPF§ùG\"”ø\é:MA\ç	¼\ÙAwñ¬\0\'-\èDF…!¨B\ÙG\'jt¦\Ü\Ç\Â4MFn§3uDO:UŞ¸hE\ÔoöĞ©zbk\ßs±h´\Øÿ\ØG\ç\Z„t²\â\×nB£\ÜôZ1l&\Òá¾x9\Z\èò‰\ß\Ò\á&b:/°\æÁ\Ô[Ìƒkt¼\é˜C7(_ù\ÌM^Ô™÷¦gV–\Ó\r\æ`!İ¢x\É\Ø\ëBp^!×]RL·Xˆ¥t“‚•¯\î\İ2gÒ²÷\èWW\ĞM–bİ§ô\Ëw~ÿ\ì\èaıŞ­C«Vºı¼ÿ°\Ñ\Ïşş/K\é>+°††‹­Á§4\\\ìS|A\ÃÅ¾ÀF\Z.¶[h¸\Ø\ä\Òp±\\\ì¥\áb{QH\Ã\Å\nQJ\Ã\ÅJQC\Ã\ÅjPC\Ã\ÅjPJ\Ã\ÅJQH\Ã\Å\n±—†‹\íE.\r\Ë\Å\Z.¶i¸\ØF|A\ÃÅ¾À§4\\\ìS¬¡\ábk°‚†‹­ÀR\Z.¶i¸\ØBÌ¡\ábs0†‹M\ÇD\Z.6#h¸\Ø¢\ábƒĞ“†‹õDG\Z.\Ö-h¸XD\Ğp± Œ†k•\ØIÃµv\Ø@Ãµ6\0XEÃµV˜GÃµ\æ˜JÃµ¦x˜†k= 7\r\×\ê\r \r\r\×jÀ\ç§\æJ7¼ûò”§G%÷\ëİµ\ÃU\Êu\èÚ»\ß\ĞQOOy\é/K¨9¿?\ØIm\íø\ëK£zµMBZô\ZùÒ²\Ô\ÖNöµ´\ã\Í\ä–¡\å\Ğÿ\ŞN-}„\Ã\æR;»\ß~\è\nˆ\Òú¹;©¹8,zÙŸ\Ñ\"u}µ€zI\ÃaP#\ïöA¬°>Ê©‘pXµññ#±.\æÁ5\ÔFkM=–t…nX Z\ã0O5P“ù ój¨2~”Cñª\Şh­´UEñrp\Äl\n˜\İ\Úi9;@\áf\ãˆ\'(Ûº®\ĞR·õ”\í	Ñ“’\íá¦<R²8\"rf\ÅAc\Í\ŞP®8µ‡Rm¸	šë¾‘R\íÁ1\Ë)TFh/\â\r\nµÇ¼@‘Š\Â~}ˆ\"½€c†R¢œ+\à\í¾¤DCqLG\nô’\Ñd\êˆc|Õ”\æ\Ğ\İp”A¥”¦Ú‡Z_Q˜ü\à0?\İOa¾\Âq¯S–·…\ã\\•KY^\Çq\Ée}s8\Ğe_Q”d×†’¬j\nGŠıˆ’´Á	ò(\Ç;>8TøbÊ‘‡-¤™8–7‹b,Ä‰\ÆRŠ\åap°&RŠ±8Ñ\â³(8Z\Ì\âFœ(´”\"|}\î\'›)Bi(Nò!%\Èm\Çk½›|ˆ“M¦\0\í\á\× \0“q²\Ûi¿šŸÁzûi¿\Ûq²?m÷,\\b2m\çÁ)²i·e!p	\ï\Z\Ú-§J£\Ív\ÆÁ5.ı6KÃ©º\Ñ^Õ‰p‘\Û´W7œÊ³Ÿ¶\ZW™J[\í÷\à4™´Ó²¸Š÷\Ú)§F•¶‚\Ë\\SE\r\Ã\é\â´\Ï\Ópÿ¤}ñ8ƒõ´\Í\×ap¨\ïh›õ8“t\Ú\æ¸\Ğ\0\Ú&gr3\í2®´œv¹gZL{ş®Ô¶‚ö(\Å-¢=ƒKıöX„3F[|—º ˆ¶†3» ’v\r×šB;T^€³XB\ì\r‡kÅ•\ĞKp6÷\Ó\ã\áb\Óiƒûq6M\Ëi¹M\áb—V\Ğr\åMqVY´\Üópµ™´\\\În0­vğB¸ZB5­6gUJ‹½—{+\Â9¼K‹u\Ëõ¡\Å\ŞÅ¹ µ6\Â\íB¿§µ\à\\\"\ÑROÁõ^¦¥E\àœ\æ\ÓJ5—\Âõº\ĞRóqnw\ĞJ\Ëa\àkZ\éœ›\'—º¦…r=8TZ§8ZøiTœO‹\ZZfŒ|F\ËÔ´Ày-¥eFÀøA:-³\ç×—–¹\Æz\Ó2}q~\Şİ´\Èn‡ET\Ğ\"»½¨ƒ)´\È\Û0~´†™‚ºH\Ğ\ZÁøQ*­H@¬¤5®€ñ£DZc%\êf -±\Æa%´\Ä@\ÔMX>­0\ÆQ«i…ü0\ÔQ*­\nã¨™´B*\ê*®Œ\ã¨\'i²8\ÔY-\Ğ\ÆQ¿¤2PwmıT.ã¨¶T\Ï\ßõE\åvÀ8\Æ[I\å²Pİ©\Ürµ6Q¹î¨—µT\íeµŞ§jkQ?ı©\Ú(µş‹ªõGıx¶P±{a\Ô\ZOÅ¶xPO£¨\Ø/`\Ô\ZI\ÅF¡¾\"÷Q­0j\r¡Zû\"Qo¨V\'µ\î¡ZP\ÑTª\rŒZ½¨TA4\Z`•ú	ŒZ7Q©qhˆ\È<ª£\Ö\ÕT)/\r2†\n\ÕÀ8®%U\Zƒ†i²‹\ê”À8.\n\íj‚\ZI…¢`\Ô\ê@…F¢¡|;¨Î•0j\İFuvø\Ğ`Q0j=HuBÃ…n¥2\É0j¥R™­¡h„¡TfŒZ¯S™¡h\Ïª’£\Ö2ª²ÁƒFI¢*K`\Ôú\'UIB#-¢\"[a^BE¡±*¨H\'G\İCE*\Ğh\éT$\ÆQó©H:\Z/:jl…qD\Ä!ª‘ H¡\"]`üh\0IA0„\äPÿ„ñ£T#\'A‘H5¶Á8,²„j$\"H2©Fw?¸jd\"XZ•R‰ÿ\rğS‰\ÒVšqT\ãxjŒCğx\×Q‰\ï/„\ë%”S‰u^Q§j*‘\×[B%ª;!¨¦Q	ÿ\rp¹;©\Æ4Wøf*‘í«…o¥›\ÃdI*‘\nWË $\İ,ª1\Z.6…j\ÌBğ\Å\î¡d¸\ÖSTcO,\èO5júÁ¥†S‘şP\"‹jTş®ô+?\ÕÈ‚\ZñT£¤;\\¨O\Õ(ˆ‡\"}©H\é¯\á:WQ‘¾P\æT\å\å0¸J\ä<ªòG¨ù-Uù\ä¸H»¯¨Ê·‘P¨sU\Éû\\\ã\î\"ªR\ÕJ§2\Õc\á\Şô\0•µ<R\Ì(¸@\Üß¨Î‡(\Ö\â\0\Õùª\ï¦\ï¨ÎPn*¾÷h%\Z¼I…\é8Xø›T\éMX!zUZy1+a=U\Ú\rK´/¦Jyı\áL!#R¥\âö°\È=*õ^s8P\Û5T*p,“Nµö\'\Ãi¼\ãÊ¨V:¬\ãYAÅ–·‚£\\û9[á….\ŞA\Å=\Ç{¾’Š\í¸–\ê\\N\Õ>n‡¸\áŸT­¼3,–B\åÊŸ	…DüW\r•K\å2¨\ŞúN\Ğ\ŞÍ›©^¬\ç[Kõª§†Ck13To­6h¾\Øù \Úò- ¶7‡-®.¤¾¾zò$\ï \n¯†Mn­¢%ş÷g\ĞPŸ¯h‰ª[a›dZd\éµ\ĞL\âÇ´H2l4‰ñÿ¹4\Òa	­2	¶šK«T¼x14\Ñ\ê\Ï~Ze.\ì\å[M\ËMˆ„\â¦W\Ğ2«}°Y\ì&Zg\ÏcQ.\îùbZgS,l—O¾˜\0Á:ıw9-”Ÿ\0º\ÑJş%½!“w\àG´TQˆXBkm\Zq.~\æ;Z«$Bôª ÅŠ¦·(×½QF‹Uô‚}ªh5ÿ\Ò\ÛB „·ÿ\ZZ®ª¹·†\Öû\æ±hp\Ñø´^Í½%%@\Ì	[]0dq9mH0\Ñe‹~›\Ä=´¬’öxâŒ§]*ÿç‹`¹KF­ª¡]\ÆC É´Oõ\ßm]ş\ä\'\Úg2DJ£ü\Ó–h÷Lm•¡\Æ\Ó^ux	”j}\Æ×´\Ùxˆ5*@\Ûm›û\èµ!PÀ\ÛeÌ‚]´]`K©¡…\Ë&&E\"ˆbnKû „Ô¤@´{«(DUöô— Z\İ÷Ú—~\nQu/„\ëSAA\ä¼3õÁ[Z„ <—÷|d\Ú{\ë‹)HEˆ×«„\â”oZú‡Ñ¿¸Ò‡:	¿æ®±¯.ûW%\Å)\é\r$Q(ÿ³\æ\Î|\áùq#†ö»­ûumšG‡\0¦—´\í”x{ÿ\äQO¥ı\ß?¾µø\ï;ª(Z\è’O]JË¨ü.\ĞD\Â&\ZA·)Úˆ]M#\ÈV\ÇB#¾¹4‚j®z™D#ˆ&A;\ÉU4‚¤*\ZºµFP\Ş\n-]½Fl¿\Zšj¾–F£­mmùf\Ğh¤t–\\F£Ê‡As¶\Ñh°\í\×C{.£\Ñ@+.‚x\Ò4\Z 0\Õg¸³F½\ß\r\Çhó\Zõôõ•pˆ™4\êevœ¥o:\Û?\0s\ÉJ\Zu´\ê28P\Èo*i\ÔA\åS!p¦›hœ\×7\×Ã±\"2hœ\Ç\ÌH8\Ù]\ß\Ó8‡‚¾p¸ø,\Zg•\çë¿‡\Æ\í\éWˆ qšÀ¬X¸E\Òf\Z§Øœ	ŸVM\ã\Õ\Ó\Â\á.\ÖÑ¨µ®\\\Ç;®”ÆJ\Çy\áF­2iü ³\Ü*1‡®—“IÉ£«å¥„Àİ¢\Ó+\èZ\é\Ñ0Ñ¥%À8,i]hCŒ£<C·\Òe¶õÀ8.ô\á\\ºH\îÃ¡0N\æµ›.±{”\Æ\éÂŸÌ§\ä?\ãÌ¢\ŞO‡\ÛÿtŒ³‹I=@;\Z\ãÜ¢ÿ7j\Û\ãQ0\Î\Ï;ğ3:\Ğg½0\ê¨\Çb?Å¿¸Œúh7³ŒQ6³ŒúŠKÍ§#\ä§\ÆÁhˆ°+\Ô\\`\åÀ0\r–0e75¶{JŒ\Æñö]ZC-\Õ,\í\ë…-Rs©\Ü\Ô0‚\ÅsÇ¼ƒ\Ô\ÈÁywx`Ux¿\Ìj¡$³_8\",(¥p¥DÀP&r\Ğ{e«\ì½A‘0‹\Z<o\Ú7opKxºN\ÊöSö¤®Vjvÿ\Û¡\à\íû›Á°§\ë¤l?m\åÏ\Ô\Õ\Ã>1·¥}pˆ¶8ôA\Úm10\ì\ç½~t\æw´\Ôw™£¯÷\Â¤\å\àWr\Êh²œW·„!‘·ı ß½¿-@E\Û\Şÿİ ö^²5\íşèŒ‹TE\Ïx´{Súˆ\ïvß³¯¯\ÜR\ÉF©Ü²òõg\ï\ëCS\Ëzynö_²·±Š¶fÿeösCz\\\æ\áañn0|\Âô9—®Xó\é·\ä\î-,­©)-Ü›»e\ãŸ®Y±t\áœ\é†¸¥C|\\\ãÿŠ\\æ˜‘PIš\0\0\0\0IEND®B`‚'),(2,'admin1234','Admin12345678.','15-1-00321',_binary '‰PNG\r\n\Z\n\0\0\0\rIHDR\0\0\0\0\0\0\0\0\0Ã¦$\È\0\0\0sBIT\Û\áO\à\0\0\0	pHYs\0\0›¤\0\0›¤¾\nIf\0\0\0tEXtSoftware\0www.inkscape.org›\î<\Z\0\0\0PLTEÿÿÿ\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0#·\á\0\0\0ÿtRNS\0	\n\r\Z !\"#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~€‚ƒ„…†‡ˆ‰Š‹Œ‘’“”•–—˜™š›œŸ ¡¢£¤¥¦§¨©ª«¬­®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁ\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ë\Ì\Í\Î\Ï\Ğ\Ñ\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\Û\Ü\İ\Ş\ß\à\á\â\ã\ä\å\æ\ç\è\é\ê\ë\ì\í\î\ïğñòóôõö÷øùúûüış\ë\Ù5\0\0\Z%IDAT\íÁ€u\Ş7ğ\ï\Ü÷\ÌmN¦©Æš\n™JoD\Å\Z[¶\ÚM\Ê)\ÛÆ˜NB’v¥\âi2–Y\ÏÓ›\íd\ì&OK1)F/\ÏZlb«GM#\ÙMj±˜\Æ4˜\æ<s\ß\ß7aœ™\Ãı¿®\ßÿºşŸ\à\Zañn0|\Âô9—®Xó\é·\ä\î-,­©)-Ü›»e\ãŸ®Y±t\áœ\é†¸¥C|§¹¬Ç\çfÿ%{k\ë¡hkö_f?7¤\Çešj\ŞõW\Ïüi\Å\æJ6Jå–•¯?{_·xúhú\Ó\á¯}TÈ *úxÆ£İ›Â\Í\Û~\Ğ\ä÷·¨H`\Ûû¿\Ô\ŞC¢–ƒ_\É)£\Êr^\Ü† \Ş\ëGg~GK}—9úz/û\ÅÜ–öÁ!\Ú\â\Ği·\ÅÀ°§\ë¤l?m\åÏ\Ô\Õ\Ã\Í\î»€\"¼}3Vòt”\í§ ş\ìI]=0,5x\Ş>\n´o\Ş\à(ŠE|¯”b•½7(†2\áı\ß)¡p¥DÀP \É\İóQ%™ı\ÂaU\È\Ï\ß*¦FÎ»\Ã#X.™¸\Ú\ÉMm#¼w¾_M-\Õ,\í\ë…\Ñ8­\ÒvRc»§$Àh°\Ğ~\Ëü\Ô\\`\åÀ0\rqÑ„=t„ü\Ô8õuÅ«%tŒ²™\í`\ÔG·…~:Šqu\ä\é÷	è³^\ç1rj\Û\ãQ0\Î-z\Â>:Ø\Ôg9®€·ÿ\é(g\ÖdL] ÿ\Ép§ó\ÜE—\Ø=\Ê\ãd¡\í ‹\ä>\n\ã8\ÏĞ­t™­C=0J\Ú@Úã°„Et©E	0¢\Ó+\èZ\é\Ñp·”<ºZ^J\\,1‡®—“·j•I\ã™­\àF\Şq¥4~T:\Î\×é´F­u\à.\áÓªiœ zZ8\\$i3SlN‚[\Ä\Î\n\Ğ8M`V,\\¡ÿ\Zg´§?œ/>‹\ÆYe\Å\Ã\á\îú\Æ9ô…“Ed\Ğ8™‘p¬›hœ\×7\×Ã™B~SI£*Ÿ\n]²’F­ºÓ·€F\í\0g‰˜I£^fGÁA\ÚüƒF=}}%\ã\ÎB\ZõV|7œÁ“ \Ñ\0©8À…\Ëh4ĞŠ‹ ½N\Ûh4\Øöë¡¹\ä2\ZP>:óÍ \ÑH>h«ùZ\Z¶¶94uõv\ZA°ıjh\é\ÖB\ZAQx+4”\\E#Hª’¡I4‚hô\â›K#¨\æú ‘\Ø\Õ4‚lu,´‘°‰F\ĞmJ€&º\ä\ÓP ¿´Ğ½ˆ†E‰\Ğ@\Ï\ZŠ”ô‚x¿,§¡LE7 Š†BU÷B´!54”ªI`øi(±\ÆÒ°Àx5†%\Ò \Ò\Z™\ÆR\'ş\â]\ß|¾\êı·22\Şz\Õ\ç\ß\ì*öS\'\ã!\Î#\ÔÄ®fŒ¹½µ§ğ´¾}ÌŒvQA˜!~Ê·wşÃ£pNQ¿—òR Ê€\Z\nw kô5¨£kFg p5÷B_VQ´\Í\Ïuö ^<Ÿ\ÛLÑªú@Œ\ålÿŒnhn3öS°Š^¢{	Åª\Ì\ê\çCƒùúeUR¬’DˆĞ¥ˆR}ÿ\ìEh¤‹ıRu\0	ùj÷“‘‚\È\'vQ¨ü\Ø.ve\Ú>¢	‚\Ä÷È¿)Ó¦X\ØÌ·š\"mŠ òù–\"­öÁ^s)Q\ÙD‚,\ì\éRJ4¶šD‰–´†­S¢I°Q2\Ú\ŞŠô\ÙF’a›[«(N\å”(1¥’\âT\İ\n›\\]Hqşu”º\î[ŠSx5l\Ñ|;Å™\rÅ¢ß¢8Û›\Ã¾µ”¦|8,ğP¥Y\ëƒõfPš]K\\»‰\ÒdÀrÉ”f~4,ùgJ“‹u*£0\Ï\ÃB\ÏP˜òÎ°Ô…\Û(K\ÍpX\ê\ZÊ²\ãbXÈ³Œ²”\ß‹õ)£,+<°N\Ze9\Ğ–\ë~€²¤\Ã2w(\Ê\Î°Á5;)J\àX¤M!E\Ù\Ñ¶h¹ƒ¢·‡%\"şAQ\n\Ú\Ã&\í(Ê¦hXa&E)¹	¶¹©„¢¼	ô¥(UwÀFwTQ”AP\î’J[\r	P’- X\ÈJŠò[\Ø\ì·\åC\Ôú\rEy¶{…¢Œ‡R+)I¶ó}NIª:C¡ˆM”¤\è\nĞº’|	u2(\Ê@ˆpEù#”¹‹¢Ì€/Q”¾P$ş{J²¾	„ğ}NI\n\â¡F%9\Øb´.¤$YP¢?EA†S”şP v%ù\ÒA<Ù”dO,‚o%	ü¢töS’Yº¤\0%yÂ¼FII²ğÍ”d„‰\İKI6‡#¸¦Q”G \ÎPŠ2\rAÕ©š’|yşNIª;!ˆ¼\ë(J/”HQ\Öy<\ã(Ê§i5E‡ iUJQú@¤\Ş¥´‚%“¢l€P\Ù%A’HY\î…P})K\"‚\"$‡¢|\ëP!ÿ¤(9!†Ê’±~EYR\Ñy%/byr)J^4\Z/²¼Á¦R–t4ZBe\éÁ®¢,	h¬E”\åŸ\ísÊ²”Da‚hS˜$4Šgeñ_\n\Ñ\âª(\Ë\Zc(…Y	\á–P˜¡h„Ğ­f„Ha¶†¢\á¢051.¢’\Â<„ó\í 0ŸA¼5f‡\r5’Ò¤C¼TJ3\r\Ôd¥\é\rñzPš]M\Ğ0c(ME\Ä+¡4c\Ğ ‘y”f54ğWJ“‰†Gqƒ¢8\ã\Ğ\0\Ñ\'\Z\èBq\n¢Q(N\ZğTPœ	¨·\È}g´ğ\Å\Ù‰ú\ZEyşZXHyF¡<[(Ï‹\Ğ\ÂTÊ³Åƒú\éO†C\É¨?\êg-ºZ\èJÖ¢^ºS¢xh!–uG}dQ bh\"Ÿe¡\Úú)\Ğ:h\â\n\äo‹ºË Dƒ&–R¢\ÔY\\%Ê‚&\æS¢²8\ÔU*EšMü‰\"¥¢\Âò)\Òh\âEŠ”†ºH™¦A“(\Ó@\Ô\ÍJ\Ê4šø-eZ‰:IP¦1\Ğ\Äp\ÊH@]L¡P@÷Q¨)¨\ïn\n5šH¡v{q~})\Õh\"…Rõ\Åù-¥TOASª¥8¯5”j241RÕ´Àù¤R¬?@¿§X©8O.\Åzšxb\åzpnwP®\Ğ\Ä\Êu\Îm>\åZMdQ®ù8§ˆC”\ëch\âo”\ëP\Îe\0\ÛM|KÁ\à\\Ş¥`h!´Š‚½‹sˆ*¥d\×AWR²\Ò(œ\İ`Š6Z¸‹¢\r\Æ\ÙeQ´ÿ€\ÆQ´,œU\ÓrŠö´0‹¢•7\Å\Ù\ÜO\Ù>‡>¢l÷\ãl–P¶bh!Ÿ²-ÁY\\PI\á.‡šS¸\Êpf\Ã(]\n4ğ+J7g¶ˆ\ÒÍ…^§t‹pF¡Å”n4°•\Ò‡\âLn¦|WB¼V”\ïfœI:\åñR(_:\Îd=\å{\âÍ¥|\ëqñ\Ê÷}¤\ÛEùñ8\İ0\ê „\ë@\Ã\é2©ƒ\é.:\È\Äi<û©ƒ½^ˆòu°ßƒSu£~\Ñn¥º\áTi\ÔC&D{“zHÃ©²©‡²yz\È\Æ)bü\ÔÄƒ\ì\×Ô„?\'»ºX\rÁşJ]Ü“M¦.WA¬+j¨‹\É8Ù‡\Ô\Æˆõ\'j\ãCœ$´”Ú¨N€P—UR¥¡8Ñ\Ô\ÈLõj\äFœh,5Rq)DjVJŒÅ‰R\'\Ó!R:u²\'Ê£NJ\â Pl1u’‡´¡^~§^\Ú\à¸dê¥¢Ä¹¼”zI\Æq¯S3+ \Îÿ£f^\Çq_Q7ƒ \Ì]\Ô\ÍW¨å«¦nv5…(‘Û©›j\éHı¼Q¦R?q\ÌP\ê§ú:rU%õ3Ç¼@\r­õBŒ\Õ\Ô\Ğ8f9u”1&RG\Ëq\Ì\ê\È\ßBü¬†:Úƒ£â¨§¼Ÿ@„¸]\ÔS\èIM­\0!Ë¨©8\â	\ê\êYğ4uõ˜M]U\'\Âvİ«©«\Ù8\"‡\Ú\Ú\Ó\Z6k½‡\Ú\ÊÁ<e\Ô\×\æf°U³\Í\ÔW™‡µ¦\Î\Ö5…š®£\ÎZ\ã°$j\íl\ãû€ZK\ÂaPo<°‰gõö\0K£\æfÀ&3¨¹46—º{96y‰º›‹\Ã>¢ö2\Ã`¹°y\Ô\ŞG8l\'õ·2\Z‹ZNı\í\Ä|~:@N3X\ê\âl:€\ß \ras,\Ô\ê:B\0½\éy7\Â2v\Òzx˜Qù8,2²‚ñ0€©tŒEÀ1\èSÌ£sl»\Êu\ŞJ\ç˜`¤òq(6º’²\nÀ:\Ê\âK¡Ğ¥‹\é(\0ì¤³|2Šx\Ç¤³\ìPF§ùG\"”ø\é:MA\ç	¼\ÙAwñ¬\0\'-\èDF…!¨B\ÙG\'jt¦\Ü\Ç\Â4MFn§3uDO:UŞ¸hE\ÔoöĞ©zbk\ßs±h´\Øÿ\ØG\ç\Z„t²\â\×nB£\ÜôZ1l&\Òá¾x9\Z\èò‰\ß\Ò\á&b:/°\æÁ\Ô[Ìƒkt¼\é˜C7(_ù\ÌM^Ô™÷¦gV–\Ó\r\æ`!İ¢x\É\Ø\ëBp^!×]RL·Xˆ¥t“‚•¯\î\İ2gÒ²÷\èWW\ĞM–bİ§ô\Ëw~ÿ\ì\èaıŞ­C«Vºı¼ÿ°\Ñ\Ïşş/K\é>+°††‹­Á§4\\\ìS|A\ÃÅ¾ÀF\Z.¶[h¸\Ø\ä\Òp±\\\ì¥\áb{QH\Ã\Å\nQJ\Ã\ÅJQC\Ã\ÅjPC\Ã\ÅjPJ\Ã\ÅJQH\Ã\Å\n±—†‹\íE.\r\Ë\Å\Z.¶i¸\ØF|A\ÃÅ¾À§4\\\ìS¬¡\ábk°‚†‹­ÀR\Z.¶i¸\ØBÌ¡\ábs0†‹M\ÇD\Z.6#h¸\Ø¢\ábƒĞ“†‹õDG\Z.\Ö-h¸XD\Ğp± Œ†k•\ØIÃµv\Ø@Ãµ6\0XEÃµV˜GÃµ\æ˜JÃµ¦x˜†k= 7\r\×\ê\r \r\r\×jÀ\ç§\æJ7¼ûò”§G%÷\ëİµ\ÃU\Êu\èÚ»\ß\ĞQOOy\é/K¨9¿?\ØIm\íø\ëK£zµMBZô\ZùÒ²\Ô\ÖNöµ´\ã\Í\ä–¡\å\Ğÿ\ŞN-}„\Ã\æR;»\ß~\è\nˆ\Òú¹;©¹8,zÙŸ\Ñ\"u}µ€zI\ÃaP#\ïöA¬°>Ê©‘pXµññ#±.\æÁ5\ÔFkM=–t…nX Z\ã0O5P“ù ój¨2~”Cñª\Şh­´UEñrp\Äl\n˜\İ\Úi9;@\áf\ãˆ\'(Ûº®\ĞR·õ”\í	Ñ“’\íá¦<R²8\"rf\ÅAc\Í\ŞP®8µ‡Rm¸	šë¾‘R\íÁ1\Ë)TFh/\â\r\nµÇ¼@‘Š\Â~}ˆ\"½€c†R¢œ+\à\í¾¤DCqLG\nô’\Ñd\êˆc|Õ”\æ\Ğ\İp”A¥”¦Ú‡Z_Q˜ü\à0?\İOa¾\Âq¯S–·…\ã\\•KY^\Çq\Ée}s8\Ğe_Q”d×†’¬j\nGŠıˆ’´Á	ò(\Ç;>8TøbÊ‘‡-¤™8–7‹b,Ä‰\ÆRŠ\åap°&RŠ±8Ñ\â³(8Z\Ì\âFœ(´”\"|}\î\'›)Bi(Nò!%\Èm\Çk½›|ˆ“M¦\0\í\á\× \0“q²\Ûi¿šŸÁzûi¿\Ûq²?m÷,\\b2m\çÁ)²i·e!p	\ï\Z\Ú-§J£\Ív\ÆÁ5.ı6KÃ©º\Ñ^Õ‰p‘\Û´W7œÊ³Ÿ¶\ZW™J[\í÷\à4™´Ó²¸Š÷\Ú)§F•¶‚\Ë\\SE\r\Ã\é\â´\Ï\Ópÿ¤}ñ8ƒõ´\Í\×ap¨\ïh›õ8“t\Ú\æ¸\Ğ\0\Ú&gr3\í2®´œv¹gZL{ş®Ô¶‚ö(\Å-¢=ƒKıöX„3F[|—º ˆ¶†3» ’v\r×šB;T^€³XB\ì\r‡kÅ•\ĞKp6÷\Ó\ã\áb\Óiƒûq6M\Ëi¹M\áb—V\Ğr\åMqVY´\Üópµ™´\\\În0­vğB¸ZB5­6gUJ‹½—{+\Â9¼K‹u\Ëõ¡\Å\ŞÅ¹ µ6\Â\íB¿§µ\à\\\"\ÑROÁõ^¦¥E\àœ\æ\ÓJ5—\Âõº\ĞRóqnw\ĞJ\Ëa\àkZ\éœ›\'—º¦…r=8TZ§8ZøiTœO‹\ZZfŒ|F\ËÔ´Ày-¥eFÀøA:-³\ç×—–¹\Æz\Ó2}q~\Şİ´\Èn‡ET\Ğ\"»½¨ƒ)´\È\Û0~´†™‚ºH\Ğ\ZÁøQ*­H@¬¤5®€ñ£DZc%\êf -±\Æa%´\Ä@\ÔMX>­0\ÆQ«i…ü0\ÔQ*­\nã¨™´B*\ê*®Œ\ã¨\'i²8\ÔY-\Ğ\ÆQ¿¤2PwmıT.ã¨¶T\Ï\ßõE\åvÀ8\Æ[I\å²Pİ©\Ürµ6Q¹î¨—µT\íeµŞ§jkQ?ı©\Ú(µş‹ªõGıx¶P±{a\Ô\ZOÅ¶xPO£¨\Ø/`\Ô\ZI\ÅF¡¾\"÷Q­0j\r¡Zû\"Qo¨V\'µ\î¡ZP\ÑTª\rŒZ½¨TA4\Z`•ú	ŒZ7Q©qhˆ\È<ª£\Ö\ÕT)/\r2†\n\ÕÀ8®%U\Zƒ†i²‹\ê”À8.\n\íj‚\ZI…¢`\Ô\ê@…F¢¡|;¨Î•0j\İFuvø\Ğ`Q0j=HuBÃ…n¥2\É0j¥R™­¡h„¡TfŒZ¯S™¡h\Ïª’£\Ö2ª²ÁƒFI¢*K`\Ôú\'UIB#-¢\"[a^BE¡±*¨H\'G\İCE*\Ğh\éT$\ÆQó©H:\Z/:jl…qD\Ä!ª‘ H¡\"]`üh\0IA0„\äPÿ„ñ£T#\'A‘H5¶Á8,²„j$\"H2©Fw?¸jd\"XZ•R‰ÿ\rğS‰\ÒVšqT\ãxjŒCğx\×Q‰\ï/„\ë%”S‰u^Q§j*‘\×[B%ª;!¨¦Q	ÿ\rp¹;©\Æ4Wøf*‘í«…o¥›\ÃdI*‘\nWË $\İ,ª1\Z.6…j\ÌBğ\Å\î¡d¸\ÖSTcO,\èO5júÁ¥†S‘şP\"‹jTş®ô+?\ÕÈ‚\ZñT£¤;\\¨O\Õ(ˆ‡\"}©H\é¯\á:WQ‘¾P\æT\å\å0¸J\ä<ªòG¨ù-Uù\ä¸H»¯¨Ê·‘P¨sU\Éû\\\ã\î\"ªR\ÕJ§2\Õc\á\Şô\0•µ<R\Ì(¸@\Üß¨Î‡(\Ö\â\0\Õùª\ï¦\ï¨ÎPn*¾÷h%\Z¼I…\é8Xø›T\éMX!zUZy1+a=U\Ú\rK´/¦Jyı\áL!#R¥\âö°\È=*õ^s8P\Û5T*p,“Nµö\'\Ãi¼\ãÊ¨V:¬\ãYAÅ–·‚£\\û9[á….\ŞA\Å=\Ç{¾’Š\í¸–\ê\\N\Õ>n‡¸\áŸT­¼3,–B\åÊŸ	…DüW\r•K\å2¨\ŞúN\Ğ\ŞÍ›©^¬\ç[Kõª§†Ck13To­6h¾\Øù \Úò- ¶7‡-®.¤¾¾zò$\ï \n¯†Mn­¢%ş÷g\ĞPŸ¯h‰ª[a›dZd\éµ\ĞL\âÇ´H2l4‰ñÿ¹4\Òa	­2	¶šK«T¼x14\Ñ\ê\Ï~Ze.\ì\å[M\ËMˆ„\â¦W\Ğ2«}°Y\ì&Zg\ÏcQ.\îùbZgS,l—O¾˜\0Á:ıw9-”Ÿ\0º\ÑJş%½!“w\àG´TQˆXBkm\Zq.~\æ;Z«$Bôª ÅŠ¦·(×½QF‹Uô‚}ªh5ÿ\Ò\ÛB „·ÿ\ZZ®ª¹·†\Öû\æ±hp\Ñø´^Í½%%@\Ì	[]0dq9mH0\Ñe‹~›\Ä=´¬’öxâŒ§]*ÿç‹`¹KF­ª¡]\ÆC É´Oõ\ßm]ş\ä\'\Úg2DJ£ü\Ó–h÷Lm•¡\Æ\Ó^ux	”j}\Æ×´\Ùxˆ5*@\Ûm›û\èµ!PÀ\ÛeÌ‚]´]`K©¡…\Ë&&E\"ˆbnKû „Ô¤@´{«(DUöô— Z\İ÷Ú—~\nQu/„\ëSAA\ä¼3õÁ[Z„ <—÷|d\Ú{\ë‹)HEˆ×«„\â”oZú‡Ñ¿¸Ò‡:	¿æ®±¯.ûW%\Å)\é\r$Q(ÿ³\æ\Î|\áùq#†ö»­ûumšG‡\0¦—´\í”x{ÿ\äQO¥ı\ß?¾µø\ï;ª(Z\è’O]JË¨ü.\ĞD\Â&\ZA·)Úˆ]M#\ÈV\ÇB#¾¹4‚j®z™D#ˆ&A;\ÉU4‚¤*\ZºµFP\Ş\n-]½Fl¿\Zšj¾–F£­mmùf\Ğh¤t–\\F£Ê‡As¶\Ñh°\í\×C{.£\Ñ@+.‚x\Ò4\Z 0\Õg¸³F½\ß\r\Çhó\Zõôõ•pˆ™4\êevœ¥o:\Û?\0s\ÉJ\Zu´\ê28P\Èo*i\ÔA\åS!p¦›hœ\×7\×Ã±\"2hœ\Ç\ÌH8\Ù]\ß\Ó8‡‚¾p¸ø,\Zg•\çë¿‡\Æ\í\éWˆ qšÀ¬X¸E\Òf\Z§Øœ	ŸVM\ã\Õ\Ó\Â\á.\ÖÑ¨µ®\\\Ç;®”ÆJ\Çy\áF­2iü ³\Ü*1‡®—“IÉ£«å¥„Àİ¢\Ó+\èZ\é\Ñ0Ñ¥%À8,i]hCŒ£<C·\Òe¶õÀ8.ô\á\\ºH\îÃ¡0N\æµ›.±{”\Æ\éÂŸÌ§\ä?\ãÌ¢\ŞO‡\ÛÿtŒ³‹I=@;\Z\ãÜ¢ÿ7j\Û\ãQ0\Î\Ï;ğ3:\Ğg½0\ê¨\Çb?Å¿¸Œúh7³ŒQ6³ŒúŠKÍ§#\ä§\ÆÁhˆ°+\Ô\\`\åÀ0\r–0e75¶{JŒ\Æñö]ZC-\Õ,\í\ë…-Rs©\Ü\Ô0‚\ÅsÇ¼ƒ\Ô\ÈÁywx`Ux¿\Ìj¡$³_8\",(¥p¥DÀP&r\Ğ{e«\ì½A‘0‹\Z<o\Ú7opKxºN\ÊöSö¤®Vjvÿ\Û¡\à\íû›Á°§\ë¤l?m\åÏ\Ô\Õ\Ã>1·¥}pˆ¶8ôA\Úm10\ì\ç½~t\æw´\Ôw™£¯÷\Â¤\å\àWr\Êh²œW·„!‘·ı ß½¿-@E\Û\Şÿİ ö^²5\íşèŒ‹TE\Ïx´{Súˆ\ïvß³¯¯\ÜR\ÉF©Ü²òõg\ï\ëCS\Ëzynö_²·±Š¶fÿeösCz\\\æ\áañn0|\Âô9—®Xó\é·\ä\î-,­©)-Ü›»e\ãŸ®Y±t\áœ\é†¸¥C|\\\ãÿŠ\\æ˜‘PIš\0\0\0\0IEND®B`‚');
/*!40000 ALTER TABLE `account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `department` (
  `DepartmentId` int NOT NULL,
  `DepartmentName` varchar(100) NOT NULL,
  `CollegeName` varchar(100) NOT NULL,
  PRIMARY KEY (`DepartmentId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
INSERT INTO `department` VALUES (1,'Bachelor of Science in Agriculture Major in Agricultural Economics','College of Agriculture and Food Sciences'),(2,'Bachelor of Science in Agriculture Major in Agricultural Extension','College of Agriculture and Food Sciences'),(3,'Bachelor of Science in Agriculture Major in Agronomy','College of Agriculture and Food Sciences'),(4,'Bachelor of Science in Agriculture Major in Animal Science','College of Agriculture and Food Sciences'),(5,'Bachelor of Science in Agriculture Major in Horticulture','College of Agriculture and Food Sciences'),(6,'Bachelor of Science in Agriculture Major in Plant Breeding','College of Agriculture and Food Sciences'),(7,'Bachelor of Science in Agriculture Major in Plant Protection','College of Agriculture and Food Sciences'),(8,'Bachelor of Science in Agriculture Major in Soil Science','College of Agriculture and Food Sciences'),(9,'Bachelor of Science in Development Communication','College of Agriculture and Food Sciences'),(10,'Bachelor of Science in Food Technology','College of Agriculture and Food Sciences'),(11,'Bachelor of Arts in English Language Studies','College of Arts and Sciences'),(12,'Bachelor of Arts in Philosophy','College of Arts and Sciences'),(13,'Bachelor of Science in Applied Physics','College of Arts and Sciences'),(14,'Bachelor of Science in Biology','College of Arts and Sciences'),(15,'Bachelor of Science in Biotechnology','College of Arts and Sciences'),(16,'Bachelor of Science in Chemistry','College of Arts and Sciences'),(17,'Bachelor of Science in Marine Biology','College of Arts and Sciences'),(18,'Bachelor of Science in Mathematics','College of Arts and Sciences'),(19,'Bachelor of Science in Statistics','College of Arts and Sciences'),(20,'Bachelor of Culture and Arts Education','College of Education'),(21,'Bachelor of Early Childhood Education','College of Education'),(22,'Bachelor of Elementary Education','College of Education'),(23,'Bachelor of Physical Education','College of Education'),(24,'Bachelor of Secondary Education','College of Education'),(25,'Doctor of Veterinary Medicine','College of Veterinary Medicine'),(26,'Bachelor of Science in Agricultural and Biosystems Engineering','College of Engineering and Technology'),(27,'Bachelor of Science in Civil Engineering','College of Engineering and Technology'),(28,'Bachelor of Science in Computer Science','College of Engineering and Technology'),(29,'Bachelor of Science in Geodetic Engineering','College of Engineering and Technology'),(30,'Bachelor of Science in Mechanical Engineering','College of Engineering and Technology'),(31,'Bachelor of Science in Meteorology','College of Engineering and Technology'),(32,'Bachelor of Science in Environmental Science','College of Forestry and Environmental Sciences'),(33,'Bachelor of Science in Forestry','College of Forestry and Environmental Sciences'),(34,'Bachelor of Science in Agribusiness','College of Management and Economics'),(35,'Bachelor of Science in Economics','College of Management and Economics'),(36,'Bachelor of Science in Hospitality Management','College of Management and Economics'),(37,'Bachelor of Science in Tourism Management','College of Management and Economics'),(38,'Bachelor of Science in Nursing','College of Nursing');
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `event`
--

DROP TABLE IF EXISTS `event`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `event` (
  `EventId` int NOT NULL,
  `EventName` varchar(45) NOT NULL,
  `EventDate` datetime NOT NULL,
  `EventTime` datetime DEFAULT NULL,
  `Location` varchar(100) NOT NULL,
  `Description` text NOT NULL,
  `HasPayables` bit(1) NOT NULL,
  `AttendanceFineAmount` float NOT NULL,
  `EventFeeContribution` float DEFAULT NULL,
  PRIMARY KEY (`EventId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `event`
--

LOCK TABLES `event` WRITE;
/*!40000 ALTER TABLE `event` DISABLE KEYS */;
INSERT INTO `event` VALUES (2,'General Cleaning - May','2024-05-05 00:00:00','2024-04-09 13:00:00','Mabolo','Monthly Cleaning',_binary '',100,0),(3,'Semester Ender Cleaning','2024-07-29 00:00:00','2024-08-16 13:00:00','Mabolo','Regular Gen Cleaning Every End of Semester',_binary '',200,0),(4,'er','2024-08-16 00:00:00','2024-08-15 23:16:00','er','er',_binary '',100,0),(5,'3ewr','2024-09-05 00:00:00','2024-08-16 00:30:00','we','we',_binary '',100,0),(6,'ewwsw','2024-08-19 00:00:00','2024-08-16 06:31:00','er','ee',_binary '',200,0),(7,'reer','2024-08-20 00:00:00','2024-08-16 07:08:00','erre','erre',_binary '',100,0),(8,'rrer','2024-09-10 00:00:00','2024-08-16 07:09:00','err','err',_binary '',100,0),(9,'rr','2024-08-23 00:00:00','2024-08-16 07:59:00','ere','erre',_binary '',100,0);
/*!40000 ALTER TABLE `event` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `event_attendance`
--

DROP TABLE IF EXISTS `event_attendance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `event_attendance` (
  `EventAttendanceId` int NOT NULL,
  `AttendanceStatus` varchar(45) NOT NULL,
  `FK_UserId_EventAttendance` varchar(45) NOT NULL,
  `FK_EventId_EventAttendance` int NOT NULL,
  PRIMARY KEY (`EventAttendanceId`),
  KEY `FK_UserId_idx` (`FK_UserId_EventAttendance`),
  KEY `FK_EventId_idx` (`FK_EventId_EventAttendance`),
  CONSTRAINT `FK_EventId_EventAttendance` FOREIGN KEY (`FK_EventId_EventAttendance`) REFERENCES `event` (`EventId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_UserId_EventAttendance` FOREIGN KEY (`FK_UserId_EventAttendance`) REFERENCES `user` (`UserId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `event_attendance`
--

LOCK TABLES `event_attendance` WRITE;
/*!40000 ALTER TABLE `event_attendance` DISABLE KEYS */;
INSERT INTO `event_attendance` VALUES (8,'Absent','10-1-00231',2),(29,'Absent','10-1-00231',3),(36,'Absent','10-1-00231',4),(37,'Absent','15-1-00321',4),(41,'Absent','10-1-00231',5),(42,'Absent','15-1-00321',5),(54,'Absent','10-1-00231',6),(55,'Absent','15-1-00321',6),(61,'Absent','10-1-00231',7),(62,'Absent','15-1-00321',7),(68,'Absent','10-1-00231',8),(69,'Absent','15-1-00321',8),(75,'Absent','10-1-00231',9),(76,'Absent','15-1-00321',9);
/*!40000 ALTER TABLE `event_attendance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payment` (
  `PaymentId` int NOT NULL,
  `PaymentDate` datetime NOT NULL,
  `Amount` float NOT NULL,
  `Remarks` longtext NOT NULL,
  `FK_UserId_Payment` varchar(45) NOT NULL,
  PRIMARY KEY (`PaymentId`),
  KEY `FK_UserId_Payment_idx` (`FK_UserId_Payment`),
  CONSTRAINT `FK_UserId_Payment` FOREIGN KEY (`FK_UserId_Payment`) REFERENCES `user` (`UserId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `regular_payable`
--

DROP TABLE IF EXISTS `regular_payable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `regular_payable` (
  `RegularPayableId` int NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Amount` float NOT NULL,
  PRIMARY KEY (`RegularPayableId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `regular_payable`
--

LOCK TABLES `regular_payable` WRITE;
/*!40000 ALTER TABLE `regular_payable` DISABLE KEYS */;
INSERT INTO `regular_payable` VALUES (1,'Dormitory Maintenance',270),(2,'WiFi Payment',300),(3,'Laptop',30),(4,'Printer',30);
/*!40000 ALTER TABLE `regular_payable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `room`
--

DROP TABLE IF EXISTS `room`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `room` (
  `RoomId` int NOT NULL,
  `LevelNumber` int NOT NULL,
  `MaximumCapacity` int NOT NULL,
  `CurrNumOfOccupants` int NOT NULL,
  PRIMARY KEY (`RoomId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `room`
--

LOCK TABLES `room` WRITE;
/*!40000 ALTER TABLE `room` DISABLE KEYS */;
INSERT INTO `room` VALUES (1,1,6,0),(2,1,6,0),(3,1,6,0),(4,2,12,0),(5,2,6,0),(6,2,6,0),(7,3,6,0),(8,3,6,0),(9,3,6,0);
/*!40000 ALTER TABLE `room` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `room_allocation`
--

DROP TABLE IF EXISTS `room_allocation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `room_allocation` (
  `RoomAllocationId` int NOT NULL,
  `StartDate` date NOT NULL,
  `EndDate` date DEFAULT NULL,
  `FK_RoomId_RoomAllocation` int NOT NULL,
  `FK_UserId_RoomAllocation` varchar(45) NOT NULL,
  PRIMARY KEY (`RoomAllocationId`),
  KEY `FK_RoomId_idx` (`FK_RoomId_RoomAllocation`),
  KEY `FK_UserId_idx` (`FK_UserId_RoomAllocation`),
  CONSTRAINT `FK_RoomId_RoomAllocation` FOREIGN KEY (`FK_RoomId_RoomAllocation`) REFERENCES `room` (`RoomId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_UserId_RoomAllocation` FOREIGN KEY (`FK_UserId_RoomAllocation`) REFERENCES `user` (`UserId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `room_allocation`
--

LOCK TABLES `room_allocation` WRITE;
/*!40000 ALTER TABLE `room_allocation` DISABLE KEYS */;
/*!40000 ALTER TABLE `room_allocation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `UserId` varchar(45) NOT NULL,
  `FirstName` varchar(45) NOT NULL,
  `LastName` varchar(45) NOT NULL,
  `Birthday` date NOT NULL,
  `Email` varchar(45) NOT NULL,
  `PhoneNumber` varchar(45) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `UserStatus` varchar(45) NOT NULL,
  `UserType` varchar(45) NOT NULL,
  `FK_DepartmentId` int NOT NULL,
  `AvailWiFI` int NOT NULL,
  `HasLaptop` int NOT NULL,
  `HasPrinter` int NOT NULL,
  PRIMARY KEY (`UserId`),
  KEY `FK_DepartmentId_idx` (`FK_DepartmentId`),
  CONSTRAINT `FK_DepartmentId` FOREIGN KEY (`FK_DepartmentId`) REFERENCES `department` (`DepartmentId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES ('10-1-00231','Rhuel','Laurente','1993-07-31','johnrhuell@gmail.com','+639099153674','Brgy. Combis, Dulag, Leyte','Active','Dormitory Adviser',28,0,0,0),('15-1-00321','Darius','Mendoza','2024-04-12','darius@gmail.com','+639099163732','Brgy. Dar, Baybay City, Leyte','Active','Assistant Dormitory Adviser',14,0,0,0),('22-1-00223','Test','Subject','2024-08-15','joe@gmail.com','+639099153546','Somewhere','Active','Regular Dormer',26,1,1,1);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_payable`
--

DROP TABLE IF EXISTS `user_payable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_payable` (
  `UserPayableId` int NOT NULL,
  `TotalPayable` float NOT NULL,
  `RemainingBalance` float DEFAULT NULL,
  `FK_UserId_UserPayable` varchar(45) NOT NULL,
  PRIMARY KEY (`UserPayableId`),
  KEY `FK_UserId_UserPayable_idx` (`FK_UserId_UserPayable`),
  CONSTRAINT `FK_UserId_UserPayable` FOREIGN KEY (`FK_UserId_UserPayable`) REFERENCES `user` (`UserId`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_payable`
--

LOCK TABLES `user_payable` WRITE;
/*!40000 ALTER TABLE `user_payable` DISABLE KEYS */;
INSERT INTO `user_payable` VALUES (1,4150,4150,'22-1-00223');
/*!40000 ALTER TABLE `user_payable` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-08-16  8:52:18
