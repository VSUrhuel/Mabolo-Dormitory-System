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
-- Table structure for table `acc_fines`
--

DROP TABLE IF EXISTS `acc_fines`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `acc_fines` (
  `AccFinesId` int NOT NULL,
  `Month` varchar(45) NOT NULL,
  `Amount` float NOT NULL,
  `FK_AccFinesId_UserId` varchar(45) NOT NULL,
  PRIMARY KEY (`AccFinesId`),
  KEY `FK_AccFinesId_UserId_idx` (`FK_AccFinesId_UserId`),
  CONSTRAINT `FK_AccFinesId_UserId` FOREIGN KEY (`FK_AccFinesId_UserId`) REFERENCES `user` (`UserId`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `acc_fines`
--

LOCK TABLES `acc_fines` WRITE;
/*!40000 ALTER TABLE `acc_fines` DISABLE KEYS */;
INSERT INTO `acc_fines` VALUES (1,'August',400,'22-1-00223'),(2,'November',1000,'22-1-00232'),(3,'September',100,'23-1-02140'),(4,'November',1000,'22-1-00235');
/*!40000 ALTER TABLE `acc_fines` ENABLE KEYS */;
UNLOCK TABLES;

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
INSERT INTO `account` VALUES (1,'admin132','Admin12345678@','10-1-00231',_binary '‰PNG\r\n\Z\n\0\0\0\rIHDR\0\0\0\0\0\0\0\0\0ôx\Ôú\0\0\0sBIT|dˆ\0\0\0	pHYs\0\0\Ä\0\0\Ä•+\0\0\0tEXtSoftware\0www.inkscape.org›\î<\Z\0\0 \0IDATxœ\ì\İwœ\\W}÷ñÏ¹S¶hµÒªKV±z³q\ïF…fJ !”$$„„x!Ï“b\à	yB\è!’\0¡\ÆL7\Æu-É¸iec\Ù\êVÛ•\ÕËªl™r\ï\ïùc%[²Ú–™9s\ç~ß¯—AZ\Í\Üù¾vv\çş\î¹\çüCDªZ\ëV«\æÕ…\á…!nª9.p\Î&X\Ä8\"Z\\\àšÌ¨«3h°ˆ,´E\Î\Ñ™…8Rvü0\âE/S\0ú%×‰#\Äì°ƒ¼]8ºqÖ…8\ë\Ä\èÄ¬\Ó\\p\È\"\ëR¶·h™}™]\ì]´\È\Ëş\Í‘As¾ˆ$\Ùc\ëmz.^\î\"÷g6;‚©8\ÆYHK\Ã–‰ŒÀw\ÎAÚ‡c/\Æ>\Ãv€{³lRQ–Ù±h®\Û\ï;¤HR©\0)#3s+w29U`v\ä˜m\Ùf3\"cš™\r\"03\ÂÈˆ\"0³óºVô<l\àYÌ%\å6Ÿ]6¯¾ıV\ç\"\ßEj•\n\0‘0³`U\Ó\r.;˜o0høñ 4#Š‹ 2#<^($Hë³µ˜[\ã·bñ™}ê¶¾Ù¹\Ğw8‘¸S 2@›6Yİ¡:.q\Æe\\†q°\0h,÷kE}…A¾P$ª,€\Æ&œ­r°\n\çV;š~\âuW¸n\ßÁD\âD€\È9\Ün–š±ƒq«\\f}\'ûŒ\ïl\'œ(\nú\n#²¾¿\'LXk¸\Ç¢G‰\ì±eó³kuA\ä\ìT\0ˆœ¤m³°,×™q­ƒk«€fß¹Ê€ğDQ\Z¡I&\0\0+\rÅ¹_\ÕY\ê¡æ¹£¾C‰T\0’h\í³\áu\İ\\MÀRŒ\è;\áW\Í\Õ}©˜õ\Í#(/¢(q·\r\0BŒ\r\î!3\î\\ªU«$\ÉT\0H¢<\Üa\rY\ã\Æ^ÀRƒ‹!¶\Ë\ìM\Ğ÷-x\Ê9\îu÷’I?´hº\ëõJ¤RT\0H\Íkë°‹1^ağ\n\àF1+¿Ö™A\Z\Å\È(†Q’–!¬XaÆ½i¢»o_÷´\ï@\"\å¤@j™«Ú¹\Î^‹ñFú–\â\É\0D\Ññb \Ø7±0™l;.¸\Û\"~Ô§\î\Õ\è€\Ô\Z\0RZ·Z}SÀ\rğ:g¼˜\à;S­ˆ\Â0\ê»]%ªI\ÑÉºœq\ØOsQæ§¯Z\èú$2T*\0$¶Vo·–<,µ€\×ñ\Ã}gJ‚bhIœ8\0£•\È\î‹™/½\Ø\íñHd0T\0H¬´\í´1Q‘7;x#ğ2 \í9R¢Â¾9\Åb2+úVü\Êv{*\È\Ü~\Ól·\Ïw ‘şR Uo\Í\Z\Ëv5ñJğvŒ\ß\0²¾3É©Ì …bD&¸€G1ûf\ÖeşG=¤Ú©\0ªµj»]ü¾3\ŞŒõGúÇŒ¾[\Å\Ä./\è6³ŸºTğ\íı³S¿\Ô\ŞRT\0HUyt‡MN‡ü®9ş\ÍŞ½\Å@¡%·)\ï.\àû\ÑW—Î«[\í;Œ\È	*\0Ä»5{­©«—\ßvğûÀM$°1O\Í{\Ñ-‚„\n\0ü\Êa_\'\Ì|o\ÑBw\ÌwI6\0\âÍª›Ác¼\å;T\Æó£…ˆÄ¶€£8÷?}iñ\Ü\ìS¾\ÃH2©\0Š2³ ­\Åü	\Æo)ß™Ä»\n…(±K\nVaöõM™o]7\Åõø#É¡@*\â\ÑMÖœ\ÊòV\ï\æû\Î#\Õ\Åò…¾¹É­\Ø\ë\à?RQúK7-p»|‡‘Ú§@\Êj\ås6\×\"ş\ÜóGª›Ãˆüñ	•wğ“\Ğø\ì\Òù™G|‡‘Ú¥@J\ÎÌ‚U¼\Ş\à}ô5\ë°bh\äQ‚÷\"\0\à!\Ì}vù¼Ôou.¹\ë(¤,T\0HÉ˜Y°²\×8Ç­Àe¾óHmO\ÌHnƒ!ÀmqD_ .ómJ$¥¢@†l\Í\Z\Ëv7ñV‡\Ö\îK™D‘Q(\Zùb¢/„wšñ\Ù:—şŠ:\r\ÊP©\0AÛ´\É\ê:³ü¿¦ø\Î#\Épb\Â`\ÂNŒ/d\n\é\Ï\İx‰;\ä;ŒÄ“\n\0°5{­©«‡?r¿&ú\Î#\ÉT3ø·B˜ş¤¶(–R ıö\Ø\í\"\Ş\ç\à½ÀH\ßyD@#\Ç¾ÒŸ\Ğö\Ä\Ò_*\0\ä¼\ÚvZ#\ŞkÿNüR¥\ÔK\08>\"e\Òÿôò™\î°\ï0R\İT\0\ÈY\ï\Ú÷{8ş	˜\ä;HD\'\n0JrwÁş…ºô\çµj@\ÎF€œ\Ñ\Ê\í¶Ç§K|gŒ(2r…ˆb¢—Z;ğ\Ñıs3\ßĞ–\Äòb*\0\ämvµŸ¤oW>‘\ØC#w|\Â[o\Î}`\É\Üô]¾ƒHõP \0´mµy–\æcoB?Rƒ\n¡‘Ï‡IŞsüœ |ÿ’\Ùõ›}gÿôAŸpn±ñ\é7\Ç;´\ï<\"\åtb+\â\\!\Ñó\nÀ—\ÃLú#š(˜l*\0\ê¤	~ŸFû\Î#RIf;¾b Á8\ì\ãû\æf¾¨ùÉ¤ k·+ø7\à*\ßYD|Š\"£7Ÿø\r‡ˆ\ï_:7³\Âw©,\0	òp‡J\Ã?8\ã/€Àw‘jQ\\>\Ä\\˜\ã\çi+ş\å\Íó\Z¶ú\Î\"•¡ \ÌÌµµóö\ã\Ëú\Æø\Î#R\Ì —¾\ë =À­nWú3‹¹¢\ï0R^*\0j\\\Û6»,\nø7\×ø\Î\"adô\æ\"¢$À\ê\È\Ù/›]\é;ˆ”\n€\Zõp‡\ÊŸ\0Ş…†ûE,_Œ\È\ç\İV¸|©Kÿ\í+_\âº|‡‘\ÒSPƒVv\Ø-\Îøƒ|g‰3‹Œ\ÄOt[\\`\ï^4\'sŸ\ï$RZ*\0jÈ“[md1\Í?cü‰\ï,\"µ¤P\ì\ë\à»\î\ë™|\êƒ7^\âù#¥¡ F¬\ì°Wcü0\Ùw‘Zd=ù0\Ù-…{À}hñ\Üô7}G‘¡Ssm›m„eù¤®úE*#_Œ\È\'{4\0\à\'\é(ıg7-p»|‘ÁSc«\Ú\í•üº\ê©(3£\'—ô¹t:\çşl\Ñ\Üôm¾ƒ\È\à¨\0ˆ¡¶\Í6\Â2|øC\ßYD’Ê€b1\"—\ì•€}Ë…™?_´\ĞóDF@Ì¬\ÜnKq|\r˜\â;‹ˆôµ\îI|\ß\0·52ûİ¥ó3øN\"ı§ &Z\Í\ÒM\íü=£uı\"U\'W\è›`E3şñÀ¼ôÇµ¹P<¨\0ˆÇŸ³).\ä»À\r¾³ˆ\ÈÙ…¡Ñ›Iò\Ô\0­A:ı7\Ïr¾³È¹©\0¨r+\Û\íõÀ\×Ğ–½\"± \å‚\0v¸÷,š—ş\ï rv*\0ªT[›el<\ÇøzŸDbÅ€B¡¯yP’™sÿS\ï\ÕÁ\ê¤Kzb‹M+¦¹Møˆ\Ä[\Z=	\ßf\ØHı\æ\â…uk|‘Si2Y•Y\Ùno\rÓ¬\Ö\É_$şR)Gc}št*\Ñ\×ZsH´®/¾\Éw9U¢*«\É\ÃÖø¼9\Ş\å;‹ˆ”^®Q($ºg€ÿ\êv¥ÿj\Ñ\"WôFT\0T…\'\ÚmR?®òEDÊ§x|•@\Âo	,‹\n\é·,½\Ø\íñ$\éT\0xö\Ø»6ˆ¸˜\è;‹ˆ”Ÿt÷†	od\Û1~kñü\ì*\ßI’Ls\0<z¼\Ã~7ˆ¸üE\Ã9Ö\"Nòõ—›†s¿ºC^·<=JòO 7·›¥¦\ï\à1ş\Æwñ\'_Œ\Èk/o\ÕË¼ûº)®\Çw’¤QPawØ¨Œqğr\ßYDÄ¿Bh\ä’>/Àx\ÌE\é7,Z\èvû’$*\0*\èñ\í¶\Ğ9~\ÌòEDªGß†B\Én!<\ç{\í¢9\Ù_û’šP!+;\ì\çø:ù‹È‹A_¿€T\èk²,r\Ë\ï\ßP|µ\ï I¡ Ú¶\Û\ß`ü\á;‹ˆT\'ç ¡>E:\è\å\á\Îì§­\ëò\ïö$	]n–›™¹U|\Ò\àƒ¾³ˆH|äµ€a||Ñ¼ô­Î¹d\ß)#\0e²i“\Õu\Öñ\r\à-¾³ˆHüŠ}Mƒ’\ÌÁ÷©Kÿş¢\é®\×w–Z¤ \Úg\Ã\ëz¸\Íô‘!P\ç@\0v.ı‹\æºı¾ƒ\Ô\Z\0%Ö¶\Í&š\ã8.õED\â/<¾B \ÑE€sÏ¦\Â\â-7/¨\ß\ä;J-QPB«¶\Ùü(\Å]\Ó|g‘\Ú™\Ñİ›ô\"€=Dö\Zµ.\0%\Ò\ÖaW›ñs`Œ\ï,\"R{\"ƒ\Ş\\H˜\ìf\Ç\"xı\Òy™V\ßAjA¢×›”\Ê\Êv{½ “¿ˆ”Ià ¡.•ô^Müüşu…WøRT\0\Ñ\ã\íöN\à‡@£\ï,\"RÛœƒ\Æú\éT¢‹€F\çø\ÉıëŠ¯ó$\îT\0A[‡ı±ƒÿR¾³ˆHr4\Ô%}7Aê³İ¿¡øv\ßA\âLÀ =\Şa\ï2\ã+\è{(\"4d_¤œ\Ù\×[\×\çÿ\Èw¸\Ò\ÉkVn·w;üEÄ³†lŠL²o¤÷Ÿ÷¯Ï¿\ßw8JôO\Î`´µÛŸ\Z|	}\ï\íÈ±c\ìÙ·½\Ğ\Õ\İMOO\Ş||>Oo>Ooo\ÎwÄª·q\ã\Zœû\×(•N‘É¤illd\Ü\ØqLŸ2•k®¸’–\ÚV\ãd½ùB1Ñ«p[\Í\Í|\Ôw8\ÑIl\0\Ú\Ú\í¯>\å;‡TÖ¾Ù¸e+›·og÷¾}\ì\İ€œ:“U×¡=ƒ~nCc#sf\Í\æ\r¯~-Ó§N-aªx2 7Q,&zÿ\0şyÉ¼\Ìÿö#.T\0ô\Ó\ã\íöAÿ\â;‡”_wOOo\ØÀ\Æ\Í[Ø¸u+;ûT“†R\0œld\Ëh~\ë5¯\ã\Æk¯-\Éñ\â¬7QHx\0||ñ¼\ÌG|‡ˆ\0ı°²\Ã>„ñÏ¾sHù„Q\ÈÚ›xô\É_³fıF\na\Ñw¤šWª\à„‘-£y\Ïş³g\Ì,\éq\ãFE\0˜\ãÿ,™›ù¾sT;\0\ç\Ñ\Ön6ø˜\ïRû\äÁG¥mõjuuû“(¥.\0ú8®¼üJş\ì\ï$’;G7—\È\'½0{\ï’ù\Ù/ú\ÎQ\ÍT\0œC[‡½×Œ/ø\Î!¥·s\Ï\î^¶œUÏ¬Á¢dPúR OK\Ëh>ò\×MËˆ–²½Fµ\ÓH\0f\ÎŞ½dnö?}©V*\0\Îb\åv{;o \ïQMi\î9\îzpO¯ß€%zgÿ\ÊY\0\0\Ô\Õ\×ó÷øS.¸ ¬¯S\Ízò!\Åd¯\Í\ÜÛ—\ÌOÿ\ï \ÕH\'·3X\Ùn¯\î\0Ò¾³Hi\ë\ê\æ\Ç÷\ÜÃ£O<©•(w\0\Édù\èÿş;&M˜Pö×ªFF\ßB\Å0\Ñ?ó3÷[K\æ§\æ;HµQğ\"m;l‘Eü¨÷E†.2\ã‘U«øñ\İ÷\Ò\İ\Ó\ã;œ¤\0@}Cÿü‘2¢9™½\è\î\r‰’½‹`Şœ{Ã’¹\é»|©&*\0NòX»]\à\î;‹İ®½{ùö~Ì¶¾£\ÈTª\0\03fŸú\è\Ç+öz\Õ\Æ\ìx\ìÑ¯nxõ’9™å¾ƒT\0\Ç=\Úa³S\Æ\n`¼\ï,2t>ñ$\ßû\Ù\Ï\É\n¾£\ÈYT²\0\0¸şšx\×Û“»wLAw®H²k\0c¶dñü\ì*\ßAªAr\×Éœ\ä\Ñ69÷¢“\ì\n¾û“Ÿğ­şH\'9\ÅÃ=Lû\ß1¼	h¬K\á’}\Ù7\ç~Ùº¦w–\ï \Õ ñ@\ÛN“2\îÅ˜\æ;‹\Í\î½ûø_úw~µRÅ½œ\Î,\â‹_MöŠ° p}E€\ï ~±T\êg+V[r×ˆ—\è\à¡}6ÜŠüc\ï,24\Û:vğÙ¯~•\İûöù\"Ul\ï\Ş=<ñô3¾cx†ú”\ï¾\Í+d‹?¼}e}ñ)±€™u=|¸\Üwš§7l\àó_ûº:ùI¿\Üş\ãø\à]*p\Ôgûñ\Â\ËF…o˜gK\Ê\Z–ØŸ€¶>\r¼\Şwš\Çıÿù\Ût¿_úm÷\î\İ\ìİ¿\ßw\ï2\é€l:±§\0\0œso}`}ñ|\çğ%‘\ïş\ÊvûC\àı¾s\È\Ğ<´r%ß¼ã‡„Q\è;ŠÄŠñÓ»µ ›\rH§{€s|¤u]ñ|\çğ!qÀªm¶øw\ß9dhV¯[\Ïm?»S]ıdPY·\Îw„ª\à€†º© \ÑE€3gÿÙº±°\ÔwJKT°r»Íˆ¾d|g‘ÁÛ´u+_ı\Ş\í\Ú\ÄG\íp\ç!òÅ¼\ïU£^\Ë3qÇ²u¹‹}©¤\Ä\0w\Ø(wc|g‘Á\ëØµ‹ÿöw)‹¾£HŒ™E<ı\ÌZ\ß1ªFà ±>ñE@s\è\ÜO[\×Xb6HD\Ğ\Öf™\Ü\ÌñE\ï\è±.¾ü\ÍoÓ›\Ëù\"5`\Óö­¾#T•À9\ê³I\ï\à.´tñG¿\Ødu¾“TB\"\n\0\Ç0–ø\Î!ƒ™ñ\ÜÁ\á£G}G‘\Z±s\çN\ßªN:\å\ÈfqZ8;\ãšú0ü¼\ï•Pó\ït[»}\0øS\ß9dh\îY¶œu\Ï>\ë;†Ô®^\ßªR6N\'{\0\ìİ­\ëó\ä;E¹\ÕtĞ¶\Ã|\Òwšg·m\ã\Î\ÖV\ß1¤\Æ\äu+\é¬\ê3)‚„O0\Ü[\×\ç¯ğ£œj¶\0x|«M°ˆ\ï\0‰\ïyg¹\\¯ÿD¡füKiu÷ªs\ä\Ù8\ruA\Â\çPopG\ë«Ù‰\ã5Y\0´š¥Iq;0\Ñwš;h¥óğ\ß1¤uuuùPÕ‚ÀQ_—ô\ë\'7Õ¬x\Û\íf5ù¨\É ©O8¸\Ñwš{öò\à#ù!5ª·§›»wùQ\Õ\Ò)—øvÁÀ’1‹ó¢j\î}l»½\Ç}ç¡13nû\ÉO\Õ\æW\Ê\ê~ø#\ßª^]&Hz§@0şO\ëú\â›|\Ç(µš*\0\Øb\Ó\Ç7 é·®\â\ï±\'\Í\æöv\ß1¤\Æ=³n5›¶lö£º¹¾vÁ	¯œa_»oSn\ï ¥T3@\ëV«\Ó\ÜŒòE†&ŒB\î|@³ş¥ü,2>õ\ÅÏ³k\Ï\ßQªšsPŸM%ı\ÒjxP¾ßºÆš|)•š)\0†|¸\Üwº•¿^\ÍÁ\ÎN\ß1$!r¹ş\Ä\Çiı\ÕC¾£TµT\ÊQ—ôù\0–ª&A5QÏ­l··\ßõC†Î¢ˆÿ\ëÙ³Oûµ×º®C\Õw\Õ=bD—½\ä%¼ä¢‹™0v<uuiZF´øUUzr!\Å0Ù»p:\çŞºhnú{¾sU\ì€U\Ûl~°\æ;‹\İ\Ï<\ÃWo»\İw©€j,\0\ÎÆ¹€L&\Ãğ\á\ÍL7\Ë/½”ë®ºŠúl\"ZÆŸ\"2\è\î-’ğ¸;\Ã0ı’—/t±¨\ë \Õ,\İ\ÔÁ\ÃÀ•¾³Hiü¿û2»´4+	\âT\0œ‰s\'M\â\å7/b\Ñõ7øSQ\Å\Ğ\è\É%|…±|ÿ¼ô\â7;\ÛoD¬o\è4up+:ù×Œ]»tò—\Ø0‹\Øù\Ü¾ñ\İoñgú\0?»ûnß‘*&rd4\à¦1Š\å;\ÆP\Äv`\Õ»&ŠX¤}g‘\ÒøÁ/\î¢õ\áG|Ç\n‰ûÀ™>‚?y\Ç;¹x\Ş|\ßQ\Ê\Îºs!Q”\è{svÃ’¹\Ù\Ç}ŒX–pm;­1Šø:ù×Œ(ŒXµúi\ß1D†\ä\è\Ñ\Ã|ú_?Ï—¾şU\ßQÊ®oi`,O!¥”qß‰\ë\ÒÀX¾{V\ä\ÓÀ\ß9¤t\Ön~–#Çù!R\Æ\ãmówŸø¿óE\ßa\Ê*8²™XFJ\Çl©ğ_|\ÇŒØ½s+·\ÛËwû\Î!¥\Õö\Ôj\ßDJ\ê¹\ç:ø\ë}„\î\î\Ú\Şu0›	H¥b{7¹$û\Ó\Ö\ÃwŠUğ\äV‰\ãk\Äxî‚œ\Î\ÌXÿ¬Ú±J\í9t\è\0û¯\é‘\04d¿u0`ÿµ|­\Åj\ÚX\0\ÅÿLöCJkç½\ÕÖ¬R£:;ò‘Oı“\ïeåœ£Nó\Æ]ñ?}‡ˆØ¼cw\Ø\ïoñCJo\ã–-¾#ˆ”\Õ\Î\çvğß·\İ\æ;FYe\Ò\Ú5\ÇkXWü\ß1ú+À\í6\Éÿ\ê;‡”\ÇÆ­[}G)»zu›6ùQV\r\Z\0g_¸\ïi\ï;F\Ä\â\İ\nŸFú\Î!¥™ñ\ì\Öm¾cˆ”Ÿ_şúùNQV.pdUŒ2Å¯ø\ÑUÿNµm³\×`ü¶\ïR‡:;\é\î\íõC¤\"\î\ä\'¿¼\ËwŒ²ªK\éV\0ğ­\ë‹oò\â|ªº\0h\Ûihè¿–\íÙ¯]ÿ$Y~yÿ=¾#”—\Z`Î¾¸bµUõV’\Õı.ù(0\İw)Ÿ½*\0$azº»¹où2\ß1\Ê*Pƒ 0\Æ³\á\'|\Ç8—ª}‡\Ú:\ìbƒ÷ù\Î!\åµg\ß\ßD*\îş\å\Ë}G(»ºL@ğ[†ı\Éı\ë\n\×ù\Îq6UY\0˜Y`_2¾³Hy\é€$\Ñ\î\İ;\é\é\éñ£\ì\ê“>\n\0s|¥­Íªò\\V•\ïN\ÛşÇµ¾sHù<\Ü\é;‚HÅ™E¬x\ìQ\ß1\Ê.¥mƒ.:\ÚTü€\ïgRu\ï\Ì\ã[m\Æ\Ç}\ç\Ê\è\Í\å}Gñ\âÉ§Ÿò¡\"²µ	6ø\Èıkmš\ï/Vu€Kó¯h\Íb\är9\ßD¼Øµ{\ï8\Ô\0\Z	ŠŸò\âÅª\ê]Y\Ùa·`Tı\ÚI)\r‹\"\n\Å\Ú\İ$E\ä\\ºº’³ıu6¥	\ŞôÀº\Â+}\ç8Y\Õ\0mm–!\â3¾sH\åôò˜™\ï\"^\n\ß*G½\00\Çg«iB`õ¼#cù3s}Ç\Ê\É\ëş¿$šÑ› .˜©À‘J%~`ş‘\á\Å÷ú\ÎqBU\0Onµ‘\æø°\ïRYaù \âUç‘£¾#TTƒ&‚ñÕ²YPU\0\Å\Æø\Î!\"RIQ”¬90.pd\Ô 9È†óª \0X¹\İf\0\ïñCDDÊ¯.\à’>`öG\Ë\Ö\å.ö\Ã{\0|¨óBDD*À©C \n]ğ9\ß!¼¾\í°kqü¦\Ï\"\"RY©´¶û^\è­\003D|4\'DD$Ih·@\0Ç§n7Kùzyo\ïÀ\Êüp•¯\×\Ò)G:\á\Ë‹Æ®/¼\İ×‹{)\0Z·Z½ƒôñ\Ú\"\"R4\n\0\æ¸õ›\Ì\Ë<8/\ßı¦4\ïÅ¨ºDD¤rR#ø¹\0nZ}Xx·WNWúŸ\Úm\Ãr9>˜øe [sL;œ¹F2~dÙ¾_£B1\â¹C]l;p”õ;;	#µ9.…útš×¾t:—L\Ç\Ô\Ñ\ÃÈ¦ún™\Í\å\Ùq°‹w°|\ãN\"5–Š¥ºl@\Ø’\ì\ß÷÷­·¯\ß0\ÏU´3T\Å€|÷8Ç¸J¿®\ÈP]~\áXny\Én7‰\áõ\çn\çİ/°j\ë~Ú´›vq\à˜v=ˆyGñ\ëp\íŒ	Œ®?\Ç\Ç\ÔÔ±¼\å\Ò1\ç\Ø\Ö\Ù\Åw\ÛÀmn¨\\P²\àx‹\àb˜\è`l\âû€ÿ[\É­\èuøñ«ÿ-*\0\à`g\'şTõ\ïÿtÍ¬q¼{\ÑLj\Ôó#3\Ö>wˆ\åv±b\Ãn¶\ì;R\â„ñ\Ôu\è…\íps,]8…ß¾b—^0š\ÆT\0ƒ¼&\ì*F|q\Ù3|\ëWkK”´|>ñ\á[™4a¢\ï\ŞE‘Ñ•û–×ŠÃ™|zú—¸C•zÁŠ\0\è\ê_â¤¹!\Ë_}	¯¼xÊ8\ÇE“Gq\Ñ\äQüù’…\ì?\Ú\Ë\ã[÷òø–½¬Ü²ıG“³!\Ì\É^0†7_5›k¦gbSı‹&$\rşL0,ğ7K.\á­W\Î\á¿v7{ô5ª”Y82©€B1Ñ·qF2\Å÷ÿP©¬\Ø€®ş\åÅªy`\æ¸f>ù\Ök˜\Ü2¬ì¯µm\ßQ\Şq\Õ;ğL\Ç!¶\í?JTc\Û$cú˜\á\\<yO\ÅÅ“G1-\Ëşº\à/¿÷+6\ì(ûk\r†F\0^`\Çz’µ7\Â\É\ä\ÓVj b#\0…¡“¿\ÄÁüI-|ñ÷¯§©®2\Ûv_8v8\Î\ë^Ú·0\æX®À\Ú‡Ø¸§“g÷aÓ\Ãl\ÛwŒbL&¹eR\Ó\ÇgÖ¸\Ì\Z\ßÌœ‰#Y0©…au/ú¸9\ØYş,À—\Şr#ÿë‡¹o\Íö²¿sM\ä“=\n\Ğ\\\ÉQ€Š\0Ç¯ş? ‰ÿR\í¦\Î~ïºŠüÏ¤©.\ÃU3\Çq\Õ\Ì\ê\åB±}ÿ1:öı÷Ü¡.:tñÜ¡c\ì?š«xq\Æ4\×3¹eX\ß£š˜<jSG71mL\é z\Öw;Œ\Ïü\Öu¼³;Çª­»}Ç‘s\Èfún\Ô\Öø\×\09Ş·bµ}®£\0)\0tõ/qĞMó\Ïo¾šæ†¬\ï(§É¤fof\Öø\æ\Óş\Í\Ì8Ø•\ç\à±^ö\í\á`W\Î\î^\åŠ\ë-p,W\àXo‘\\¡oÈ½+W$|QÁJ9†eûŠºLŠ¦ú4Muš\ê34Õ¥\ÙXÏ¨aY\Æ572jX––au¸­\å\r0¾ò{7³øS?\âHO\Şw9\çúö	(&{`D±®ø—ÀG\ËıBe/\0tõ/qñgK0}\ìp\ß1\Ì9\Ç\è¦:F7\Õ1{\Â\ßqªV½s|\é\í‹ù½ÿø¥\ï(ruGXLö‚\03\Ş×º\Æ>½h¡;V\Î\×)û8fşK\Ì\Z\ßÌ›®˜\á;†”Ù¥Z¸~ö$\ß1\ä\×\× \áZ¢ ğ\Îr¿HY€M›¬\ã\å|\r‘Rx\çó´=i\"ûš+}‡ó\Ğ\à\\ğ¿Z[­¬£ôeı.w\Öñ»Àør¾†\ÈPM\ÑÀ\âùº*LŠiÍ\Ì§[%\Õ,8\ä\Øôhbø\Ær¾BY\0Y\Îã‹”\Â\â$ş\Ã&IŒw\İt±\ïr\Z€\0û\ëò¿LVn·¥/)\×ñEJ\åú\Ù|G\n»v†&«]:\åb´Ò¤®l\İP¸¡\\\Ç/g‰õ¿\Êxl‘’p\Î1=ş%¾Z\ê«o©§œN£\0U®c—\å»û\Ø›ƒ\ãU\å8¶H)M\Ñpz‡:©y¦y\01I¹Xõ›(¯¿o]\ïœr»,€‹x¹-RJ£š\ê|GO¦\é;‚œƒl:\Ù\0¤\\º,#\ê%?I¯\Şn-~¿\Ô\Ç)‡a[şŠ_c†\×û ı\É$|\0\Ã\Şq\ß\ÓVò‰+%/\0òğn ü[¨‰”@5õ¬—ÊªO\ë\ÖO8 Jü\ïi}*[ü\ÓR´¤\ßÕ¶6Ë˜ø\Ü½\0\0 \0IDAT\ã=¥<¦ˆˆ$[F·0\ã\Ï±\ÉJzÏ²´e\Õx~˜\\\ÒcŠˆH¢©1\0\ã\êŠ\áo–ò€%-\0\"ã½¥<ˆˆh\0Àa%½\rP²`U‡]\â\àšRODD\ä„LZ“q\ÜÔº6wQ©W²ÀŒw—\êX\"\"\"/–I\'~2 \ï*Õ±Jò\İl\Ûi¿SŠc‰ˆˆœI&\íHú \0ğw?e%YiW’ÀB\Ş¨«†ˆˆ”M\à©T\âK€\Ùl\á·Kq ÒŒ§%’9\İ\0œû\ÃRf\È\ß\ÉG·\Û\à\êd©¸:}˜$V}&\å;‚B:\å?\Ğ\à†\Ö5½³†zœ!ú¥\àC=†ˆ/\Ã\Ô\n8©F5©p\\©3 .J¥\Ş1Ôƒ\é»x»Y\n\Ç\ï5„ˆ/“[Ôµ:©fŒmöAI=ÀÁ;n7\Ò0Ö\n€wğr`\ÒP!\â\Ó\ì	š»šT3Fk;\à¸J@/³¾¸t(R\àŒ?\ÊóE|Ê¤^:u´\ï\â\É\ØÆ¬†’c,­\Õ\0\à\ì\íCyú ú\Û6\Û\à7†ò\â\">]7{\rY\í—TÎŒwÜ¸\Ğw¤Œ\n\0À½¡u5\röÙƒ.\0¢¿	4öù\"¾½\á²i¾#ˆg¿s\ål\ßd‚@=€aQ¾n°O\Êø\×[†ğ\\¯\æMÉµ³\Æû!k¨\ãeó´i\\i\0goôsó¤\'v\ÙXKû¢\">9\çx\ß+.\Æ%}1±\0\Æ?¾Q{˜\ÅU:$¾5°Á«\î[gƒš\Ì4¨ X\à·\İ<•Xz\Û53¹\ì\Â1¾cH•‘Ió\Ïo¹Áw\ç\Ğm\0\È87¸\ÖÀƒ½ğ\ÖA>OÄ«Ë¦\å=K5ñKNõšy“y“\æÄ’Zƒ\ÃU¦\0x¸\Ã.ppı`^LÄ§“Zø—·]M:\Ğ†¼ˆÁ?\Ür¯ºdº\ï$2@)õ\0¸ù\îgm\Ü@Ÿ4\àOÂŒñ†Á<OÄ§\çN\äKpMujı+g\æ\Ìø—7^\Ã¿\ìb\ßQd\0t\0€T6,¼~ O\ZÌ‰ü\rƒxˆ\r\Ù4\ï\å\Åü\Ë[®Öš9/g\Æûoºˆ\ï¾û\Õ47d}Ç‘~RS 0s¿5\Ğ\ç¨\0xr«nè‹ˆTZ&ğ—]\È÷Ş³”·]3K3şe\0ŒKÆ`\Å_ÿ&}\ãµÔ§U8V;ut`ÉŠ\Õ\Ö2\'\è\'»ğz@c¨R•\ê2).™<Š\æL\ä] \İ\ŞdHRÀo]<7^<u{p\ç\Ó\ÛøÑªg9Ú›÷M^$p}s\Â\È|Gñ)“¯_|«¿O\Ğe\Ñ\Êvûº %r\ìğÂ­\é\Ùt@C6Í„LÙ¨	Aqr°\Ów‚A)\0=…ˆ|R\â	\ç\é\Æ´ŒŸRš`	—/D\ä\n‘\ï^ü`É¼L¿Wôû\Óò\ák\Èû\ÆA%y‘\Ãû¹±±\Ãwñ%¦@)µº§–Ô¥™\Ñ\Õú\áÛ±\ŞTz\Ì-³]®?\î÷“,B\'©B\ÓÁ@Sƒo\ì\ïƒû]\08\ã5ƒ\Ë#\"\"R~Z\r\0Dı?Wd\ê\ä-ƒˆ\"\"\"R*\0Àpı\îĞ¯\àñ\í¶\Ğ\à\ÂA\')³ phÅ¯\Íhİ›×ŸGö«\0p®şED¤º9\Ô\Z 2÷ªş<®·\0\"^=¤4\"\"\" \Û\0\àp/\ï\Ï\ã\Î[\0´\í´F\×\r=’È©š†iQ‰$Ûˆæ‘¾#\Ô\í\0ÀÍ¿\Ødu\ç{\ĞùG\0Š\Ü\0œ÷@\"•R‹UI¸º¬\Z«–Z\à4\0\ÖP,^{¾·\00cIiòˆˆˆ”Ÿö\08\ïm€ó—KK’FDD¤Òšˆ³!\0\í°\ÑÀ¥%K$\"\"Rfš\0—·ö\í\à{V\ç,\0œqóù#\"\"RMœ\ë›p\Â\ë\Ïù€óü\ãM¥\Í#\"\"R~\ét\â\0ˆ\ìœ\çğs\0fô{S‘j¡†@@\ß(şYµ\0X³×š€KJHDD¤\Ì4\0p\\ŞºÆš\Îö\Ïg-\0z{¹\ĞBm‰\ÚÒ¡;{?€³\0\Zş‘ø\Òm\0‚³Ÿ\Ë\Ï5\àœ³EDDª™úpõ\Ùş\áŒ\ß30./_‘ò\Ò\0\0W\ßjv\Æsı¿¸jq/o&‘ò	\í\0Œ¸\á\Ùü¼3ı\Ã\ÙH\Î:d \"\")U\0¡»\æŒ_?\ã£#®*k\Z‘\n´\\pÆ‹ú3\0N€ˆˆÄŸ–fı+\0\î°ƒ…\åO$\"\"R^šÀ‚Ö­Vÿ\â/V\0dûºÿ©ˆˆ\Ä^\à\ĞD@\ÈD=…/ş\âi€E\ÚşW*\Ã\Ğo¥$[\èR¾#$‚F x\éi_;\íQN€TF¦\Ò\\’\Ê9ò®\ÎwŠDP\0fÁù\0C€TNAw›$¡,P›ºJq*\0ÀÙ¹\03\\\\¹D’tG\İY7ª©i¹\Ì0\ßC-¸\ä\ÅOùK\ÛNfú©”Š\éFú \â\ÅÁºq¾#$F\àœfAÓ¢\r½\ÓNşÂ©#\0‘–ÿIev\Í\ä]\Æw‘Š²TŠ\İõ“|\ÇH§ùFD–9\åJ\àŒù•#I°3˜\è;†HE\í6…­\0¨$M¹\0sv\ÊR@\0\âİ`G\Íd(fho˜\î;F\â¨# p®ÀNk Rn†csj9-‰’\Zg©4kG6[*@KÁ™;s`fÆœ\ÊG\")6¦g\Ñ\ã\Z|G)‹(aı\ÈË´ö\ßM\0ƒùföüw\âù\à\ÑmLE+\0Ä£YÖ¥\æpÀòE¤„½õÍ¬u\r]i}\Äú- \éÁg¹\à\Ä_\ïÂ’I1\Çüy^\ä¶¦§±\×\Æ2)\ÚE³Å™~2%…l=M³9˜\í;L\â9ú–FIÿ<)g;\à\ÔMfúI#rº.\×È¦\ÔLÒ„Œˆ\Ó`½d¬@†BßŸ)ø(ò<\ÂT–0\ÈPLe\éJgwı$\r÷W™ÀA\ä;„o\Í„“\n€fjtDªM‘‚\Óo	Œ‹ö19\ÜI _gñ\Êq i[‡iúTƒ0\á#\0‘{şbÿùÀi@bdo0–ˆ€\Ãv\ßQ$Áö6O¥½a†\ï\ÒOš‘cÖ‰?Ÿ¼P€\Ä\Êş`´V\rˆ7Q:«“\Ìª\0p¼¨\08¾,@?\É;ÇœfU‹¹t£\ï2@\êœt±\0¬\Ş\ÌX´Pb¨à´°ø‘Oi‚_\ÜhK \0†¯Xm-p¼\0(f˜\â7\È\à\ÑFB\âG!P7\Îi\0@.›Ÿ\'n8\0O\Z_òA\Öw@¤N)\0&û#28T\0ˆ½©z\ßd4\0,Š¦\Â«\0T\0H,\å\Ñ0¬øq,\İ\ì;‚‚\Ó=\0œs\'\0˜nH<\å]†•ôRaA .1¥ó?˜\Ù€ƒI~\ãˆ^\Î\é^¬TV\è\ÖS\\¥T\0\àp\á\Ä-\0\Ç¯iD† \×\é^l\ìDñn\á\\H«\èŒ-\r`0N\0\ÆX¯iD† u”\Ê\êM©mJ\\:ÿ\ã`<@\Ğ\Öf@°Klu«pü\Ä|KÖ£™¾#\È i \0cZ[-\ä\Ç3´0R\â«\'P;ñ>ÿÓ™iñAKg;€ \Ã\è ö\İ‰«YŠj/1°TŠ\Ş@û\0Ä•C\Ó\0\0\È\ä\Ç.\Ğı‰?m\n3a\è;Á \åµ	Ô€Àc\Óı©G]“\ï2Q|G\0º²j\0w\Úˆ\Ü\ÈÀÁH\ß9D†\ê˜\n€x±ø.<˜\ã;‚•\Îÿ¸ j	0\0İ®Aó\0\â$Œg`A@gFƒ¦q§\0ˆ\"72ˆ´Eb\Ïpq\Ã}ÇşŠi# \\V?cµ@;B\à`*\0¤6vº7Floª\Óğ-\Ğ\0˜¹\Íšq\Ø5cúÍ®~a1}\0\ì\ÉNôBJAà¢‘ \ÙSRŠ.\ÍQı8W¿˜\Şÿ\Ïg)\ß1¤´(€k\nphQ«ÔŒƒ:´U½˜ö\08T§iµBs\0\0hˆT\0H\í8Œ\Äô\Ë]İŠE\ß	\Î9v\ÕOöBJE8hœF\0¤†„¤\è4¯µzY,G\0r\Ù&ŠN\ÃÿR;\ZC{©Jm\Ù\ïFû gSc9pw£®ş¥¶4 \0©-‡ƒfòd}Ç3‰\áğ¿¥\Ò\ì\ËNğCJH‹…Àa\rP\ï;ˆH©\í4\nP•\nñ+\07h\í­‰\á T\é9\×\0º±%5g_j,‘ûT£¯@œ8G{\ã\ß)¤Äœ*\00\ÒòC¤ÔŠ¤8¨g{U)bw\é\Õ]?’¼«óCJM·\0\0R*\0¤f\í	´n»ª\n¾X{\ÓL\ß¤tş\Ğ€Ô°^W§\Æ@\Õ$f÷ÿ{\ë‡s,\Ğ\æ?R³4 µmg0QªA¡»\0·›\í;‚”‰V\0\ÇG\04SJjV¯«\ãP ı®¼\Ë\Çkø¿·¾™£i5”ª]ª\08> RÓ\Ó(€_F¼\n\0\ç\Ø:l\ï\"e\0ñ\ë\Ë)2\09W\Ç\Ş`¬\ï\ÉUÈƒ\ÅgúÿÑ†1t¥‡ù!Rn¡\n\0I„©	]\ÚwŒd\ê\ÍûN\Ğo–\n\Ø\Ü4\×w)»ø¤eTT ‰’\â¹`¢\ï\É†±jÿ»¿qŠ6ıI€\rH•S`*\0$öc8\æ4´[Q1ºú/f\êÙ®®É )A\0\Å\0§@’c{jª&VJA.&€ƒ\Í\Í|§J\Ñ\0Ÿ£\é¹\"C\Ó\ã\êÙ\Z\ï;F2\äò\Ä\å“öp\ãx-û“dq}s\0z}\ç©¤n]N»`—•ô\æ|§\è—0e³–ıIÒ˜õİ¾sˆT’9\Ç\Öô4\íXN¹\\<fZ9Ç³#.\"rúYH’xõ¤,s]\n\0I^\êÙ‘š\ä;Fm2‹\Í\ä¿ıMS4ôŸD1¨M\Ë\Î\Ñ\0=¾sˆø°7«-ƒË¡\'‹¾ÿ¹º&¶5j·?I&=º ‰¶=˜B/õ¾cÔ(\êş¯rQ*Íº—ú!¾\Ä\áöT™}#\0*\0$±\"°9=P÷€K£§·ú?\\ƒ€M#/QÃŸ«òŸĞŠpFw`p\ÌwŸz\\=[‚\é\ê0T\ÅrÕ¿ªxÇˆYº\ïŸp\Õ^£VB\ä¬+ \Ów\ßÍš8$\İ=Tûµ\ÕÁ\á“Ø½Àw\ïœ¦@€=Á8ö¦´k\à ôæ«¾\çW\Ãh¶4j£\Ñ\0\0fN€\È	\íÁdö£}Çˆ—0‚\î\ê\î\'–«kb]ó%¾cH•0U\0\àL#\0\"/¶=5…Ã®\ÙwŒø\èî¦š‡şó\ÙFÖŒ¸\Üw©\":ÿƒA©\09™\áx6=ƒN§‰b\çÕ›ƒBõı3\r<\Ór…:ı\É)Ló}	\Ï8\ä;ˆHµ1›\Ó\ÓUœKBOõö+d\ZX=\êJ\"R¾£H•‰4@hv8°û}©F\ÏŠ€Ó˜Á±®ªù\Ï\×\r\ã\éQW\é\ä/g¦{\0a´7 Àn\ßADª•\áØœšÎ¾`Œ\ï(Õ¥»§oò_\ê©\É\ê‘Wj³\'9;ÿq\éì \ëBö£Í‘D\Î\ÊplOMQŸ€zs«\Î\Í~Ãš/5u’³ˆL\ç ¸lƒE\Î¾ÓˆT»\İÁx¶¤.Lö•e¡x¼\áO•q}Ã§²¡\éb\ßI¤\ê\éô\ì¿Õ¹(}ü/{\0u@9ƒA9—eVq+ª¿\ímI…Q\ß}ÿ*c©€m\Í8\ÕG˜œ_6ª¬„=ÀñK\×÷9¿.7Œu\é¹s\Ã|G©38z¬\ê&O…\ézÖºR\'\é¿*ûö\ä…ÀEš(2y—aCj6;S|G)¿\'ÿ*»t\êj\ÅS£®¦\'hôEbDK\0l@\Z \n\èpú¦ˆˆ9\ÇN7‘.†qa\Ø^›·\Ì\àhW\ßNUÂ‚€Í³\ÙS§I™2p\Z\0\0‡\Û\Ç\0Œ¯iDb\ìp\Ğ\Ì3Á|&‡;\ÕR[\rƒc\İUµ\ÉO>;Œ\r#.!\Ôû\"1©À\Ì:\à\ä@«fD-$\Åö\ÔÃ™QÜ†‹ıL\ã\ã\'ÿB•Œj¤v5M\ç¹ú©¾“H\Ì\éüp|€¥h÷G¤6r#\éu1¿:5ƒ£İ¯’“]\İ#\Æ\é\ä/%¡\0pÅ°\0„FG‚W6‹””\Åy8\íù{şU0\ìŸ\ÎÀ°zH¥ˆœZú\Ê\Ğ\Ùóÿ“l½\Ù\ì#\0\×Mq\ê[\à+\"•Ep\ä˜ÿ“*MM\Ğ<¬\ï\Ï\"%bf:ÿ\Ã\á[f»#À)-Í¶z\n#\"¾‹}\'ÿ\Ğ\ãlÿ €a0b8d\Ó\ç¼\È\0i	 ˜±\åÄŸŸ/\0lòGD¼\Ê\åı®óO¥ ©F6C]\ÖOI„H\0\ã\Ù~¾\Ì6\ã\Ù8ßº‘2 §§os\Òi¨\ÏB&«½{¤\"¬ºzYyag*\0€\Í²ˆˆQ\äg¿s}Wùuu\Ò\Ôc©,\0€3{ş\\ÿ|›\"U\á\"µ/_€®\î\Ê.ˆ\Îd ›…º4º\Ü_tş3wú€‹Øœ\ä]NEjY\ßV¾¹|ù_\Ëqü¤Ÿ\éû§“¾øe¨\0€\é\Ó€—N§£­ƒn@;kˆÔšBº»û¶ô-—T\n2\é¾ÿ\Ò]\èKU1ü-\Ã\Îya€s\r~2‰HY˜õ\r÷=VÚ“\àú®\ì\êaø0hÑ·|¯±\áø\é^J¤ªl3K_\Ö:÷\Â\Ö§.¶Xƒ\ã¥$\"¥W\Õ\ï\\\ßA\Ğw²‚¾I{A\n\Ò)\r\éK\ìh ˜skOşû)€ÁZıZ‹Ôˆt\nš‡ÿ‹½0\ê\ÄPè‰¾¨\'N\æ\Î\îø¸ >	¤¶„º\0‘­9ù¯§\0Î±©A®\ïJ^$¡\Ô\0\Ü)\çøS\æı;T\0ˆˆHm\Ñ\n€\ã\Â\Ô)·\0N)\0.Ÿ\ÂV »¢DDD\Ê\È\Ì*\Úö¢J]<Ÿö“¿p\ê€s‘Á\ê\Êf)­\0\0à©“W\0\0§·ş	\à‰\Ê\å)/­\0\0\Îpn?½÷Ÿ\ãÉŠD©€P\0\Î\ì´sûi€‹T\0ˆˆH\íP\0œ~n?­\0¨?\Æ\Ó@š…‹ˆˆ”—Ye÷½ªRùı\ÅÌºñ´`\áB—\ÇXûâ¯‹ˆˆÄ®şx\æ\Í\İiög\Üÿ\ÏÁ\Êò\ç)/\0\0\î±3}õŒ€œñÁ\"\"\"q¢\0œùœ~\æ \â\Ñò\Æ)?-„\â#gúú€+§²\è,k\"‘2Š\Ô\à\à’yu›\Îôg\Ğ\×-Hó\0DD$¶\ÂPg\à\Ñw\0<\áŒ\0€¡\Û\0\"\"_¡Z\0\Ã9\Î\åg-\0œ\ãŒ÷DDD\â@#\0\à‚³Ÿ\Ë\ÏZ\0\ä\êy(–%‘ˆˆHõ5\0J|P\È÷¤^\0\Ü0\Ö~]–H\"5\è`g\'÷>x?ù\á£|G©9…¦QÜ»\ì~vjn²ôO‰?ı\Ã\ÊW¾\Äu\í\ÏZ\0\0,+}‘\Úr°³“üü|\ìs_`ò\ØF2#\ÇRh\ï;V\Í(G¶e\ãG\Öq\ëg?\Ï7î¸ƒ½ûø%UN\ëÿw\îsxúœO6–\áø«’©û\âe+x\ä\É\'ˆÂˆ1-Í¼\æ¦+\0Èœ„¤»zNoaC3ù–I\0¼q\É5üğşGyüÉ§hûõj.]¸€\×.Y\Âø±c<§”j¤ûÿ@4„ (²\Ü2„@ª¤¡Dbl÷\Ş}Ü½|9mO?Mt\Ò4\ãw¾a1u\Ù\ÌóÏšŠ‹¤zøˆ{Q¦\Ü\è@6“\æwn¹‰\Ïû\çDf<ñ\Ì\Z~½f-—.\\Àk–,f\ÂØ±^óJõ04\0³.ığ¹\à\Îw„•\í¶\n¸¬d‘Dbjç½Ü»b+W?E§®/š<~4_ÿø{I¥N½«æ¢ú½›ò=•Œ\Z{–\Ê\Ğ3~–Îòõbò¿ûWv\î;ud%ps\æğ\Ú%‹™2ib%£J*|\è;†_\Æc‹\çg®9\×C\Î}\0Àq/¦@’«c\ç.\îzğAV¯[\ÖY\Åo»\å\Æ\ÓNş\0¤\è;“†\İq¡v\Ù\î\Ğ;vúi\'€t*Å›_uŸû\Ö\ÏOùzd\Æ36°f\ãF.™?W/zS&ªHª¢®şÁq\Ïùr«¶\Ù\â(\àş\Ò$‰»vs÷²e<¹f\í9—\rk¨\çöO†º\ÓOX\'\Å^\êwo\ÄE	¿*\é‡\Ü\è)k9\ë¿÷ô\æx\Ó_}Š\Ş\Ü93o\æL^·t	N™\\\êˆR\åºzB¢„/Œ7-›Yq®Çœw ¾‹‡º‡\Ó+Y2‘*¶¥½»—­`\ÍÆıZGüŠ\ë.=\ç\É J\×\Ó;n&\r{S{²³ÉœtÎ“?@C}K®ºˆŸ/_u\ÎÇ­ß¼™õ›73s\êT^»t	sfL/eT©R‘‘ø“?pt\ä\Ñôy»ùw\0`e»\İ¼jÈ‘Dª\Ø\æ\íÛ¹gùC<³aÃ€÷Õı\Ó/×¯Ç¦zS¿o+h…òiŠ\ÃF“=µ_}¶c7r\ë—tü™S§òš¥‹™;c\Æ`\âILŠFo\Â\ïÿ;øÙ¢y™×Ÿ\ïq\çŸ\Ğw°{M€Ô¨\ÍÛ·s\çı­lØ²eÀÏ½h\Ö\Ô~ŸüÂ†\äFM¦\î`Ç€_«–…uM\äFM\é÷\ãgM™Àœi“Ø¸}g¿Ÿ³¹½/|\í¿™9u*/¿\éF.7w0Q¥Ê…\Ú\0€\È\ì¼÷ÿ¡Ÿ@d\Ü\íŸZ$‘\ê²v\Ó&\îj]Æ–ööAã–›.ğsŠMcŠ92GöúukI”®#7v¸~\rH>\ï57_\Î\Æoö¿\08as{;›¿ıfN›Æ«\İ\ÌüY³|©^E­ÿÇˆúU\0ôû7ne»=\Ìt\"‘*±~óf~v\ßıl\ë\Ø1¤\ãAÀ?û!š›\Zõüºƒ\ÛIKv£ K¥\é?‡(]7\à\çv\é\âMø\ä\ï÷N8W\Ş|3/]¸\07À\"DªK\Zİ¹dÿ\Ï\Ë\Ì\ë\Ïû5\0€ñ\ït$ÌŒg6l\ä®\Ö\Ùş\Üs%9\æE³¦ú\äk™Š+Hõ-I\Øq\Ü\è\éƒ:ùŒl\Æ\Ü/`\İÖ¡r;v\íæ«·}&Œ\çU/{™\n\Óò?0\Ç\Ï\Ïÿ¨>ı/\0\àg @\â%2cÍ†ü\âV\Úw|¸ø\\®»tˆ÷#7f:õ{6’\×((7j*a}ÓqÍ¥s‡\\\0œğ\Ü\î=|õ¶\ï1iü8–\ŞxW]r	.8\çv)ReŠE\0A\Ôÿ \ßen[›elû€ƒJ%RA\'Nüw\Şÿ\0»v•\å5¾ù‰÷1yü\è!Ç…\Zöl\Ä“\Ó(¨0bùCoÔ³¹c7\ï\Z\àj€şš8n/¿I…@\\Dtõ&~û\Ã\Í\Ç\Òc¯¸\Âúó\às­\ì°\ïc¼ip¹D\Ê/2\ã\×k\Ör\ç}÷³{ÿş²½Î¤q£øö?½¿d\Ç\n½\Ô\ïIF£ b\ãHrcJ·&ÿw>ôv(\ß6ÁcZZx\Å\Í7r\íK/#8C·G©ùBD®\ì\0fvÛ’ùÙ·õ÷ñ¹\0?Ã©\0\êF!=ñ÷,_Î¾ƒ\åŸXw\ÕE³Kz¼(SOn\ì\ê÷n®\éFAQ¶‘\Ü\èi%=\æ\åfr\çŠs7\ZŠı‡ñ\İÿ”{W<Ä«n¾™+/½„T ıÑª6ÿÀış‡\0éˆŸS\äs·=©b²\êé§¹«õAö¨ÜŒú…3û¿f½¿Âº&r£§R·[É]\r,•¥w\ìLp¥½Š?sJY€ö8È·~ø#\î| •%\×_\Ë\rW^I:=°k()3M\0r\ÅLª|ÀK§»\Î\ÇÛ­\ÕÁ+–K¤´Ša\ÈcO>\É]­\Ë8tøp\Å_ş\Ìòô—/6¶\àZ\nd•f¥Bµ°  w\Ü,Uú\æü•\íõ°³“\ï\ßy÷=ô0Ko¸ë¯¸‚L&sş\'J\Ù\Ã(ñ\Í5\Üóò™n@†şm?0S ~\Â\"?ùk\î|\àA9\â%CsS#Çœ»_ıP†\Ãd\ÖJ£ Gnô…D™†²}Ú¤±46\Ô\Ñ\İs\îÍJ\í\Ğ\á\Ã|ÿÎ»ø\åƒ\ËY|\Ãu¼\ìškÈªğB\Í\0swô)/\ÇSü˜\"_\ÔsE)—\ÏóÈªUÜ³ü!õ»n~şŒ\Ée_\'o¹\0IwÅ¿QP~\ÔdÂ†ò-\nœc\î…ğäº·r.…£]]ü\ä\î{yà¡‡¹ñ\ê«Xrıu\Ô\×\r®·œ\Ñ\×\0(\á\n¹(õ³>iÀ\'ñ+&¹ıw\Ørg,\èsE*—\Ëó\È«¸{\Ù\n;\æ;\0ó§Wf\È97j*.Œw£ \ÂğqšÆ”ıu\æOŸ\ì­\08\áhW¿x •\å=\ÆMW_\Í\âë¯¥¡®\Şk¦$(†–ô\Ñ€û_µ\Ğ\røjaPWññC€”Owo/\Ë~”y„\î\êj’3k\ê\Ğ×¯÷K\Ì…\r\Í\ä[&U\äµ\æL«\Ğ{\ÒÇººù\Å­,{ô1]w-/»öjeT,\Öîª™şr\Î<üƒ-\02ü ,ğy@7¼¤¤zs9–?ş8÷.¨\êNü\'L0ô\æ?ıeAŠŞ±3i\Ø¯FAQ¦\Ü\è`«‘A›T‚†L¥\Ö\Õ\İ\Í\Ïï»Ÿ{W<\Ä\ÍW]\Å\ËoºÆ†òÌƒH*3\rÿù\\1ó\ÃÁ<qPÀeİ¾•\Û\í^·\æù\"/F!÷=ô0w/[N.W\Ù\É\\ÆŒ¬\èkZ:C\ïØ™±id©¾¼VÁµò“Ç\Â9‡\rqc r\È\årÜ³b\ËœW¿\ìf_w\Z\n•H1Œ?ü\ïŒ;3ü0\èŸBğÁ>W\äd=¹^>óŸ_\ã§÷\Ü[\Õ\'€q-\Íd=¬ı2õ\ä\Æ|\ËÜŠs½cg`\éÊ¶\n©¯\Ï\Ò\Ò<¬¢¯9P½¹?ºû>ûÕ¯Wı\Ïy\\¨÷?\à\Üwû\ÔA\0™?ªcV–\ÄR\ç±.Y³‘}\á\ß\Ù\Ö\Ñ\á;N¿\\\àq¨9¬o\"7ª´]ôJ­wô4¢\ì\àwHŠI\ãª\ï6À™li\ß\ÎG¾ğex\âöö³”µD‘ºÿGê†¥\î\ì“})ó’	®«m»ı\Ä¿;\ØcHò\ì\í<Âš­ll\ß\Å\Î‡\È\í\ä\è\áø,u»`\Ü(¯¯_Ö‚ód;K»³a)\äG^@\ØX\Ù\Û#Êˆ&2\0\0 \0IDAT\'›<n\Ïl\Ú\î\íõ\â\Ø\áƒ\Üó«GYö\ëu´\Æ\Ü)“X0}2SÇ©úAjQˆ4ü\îë¦¸AO–\Z\ÒX¦|S ggf´\ï=À\Æö]¬k‡O]\Ò\Ösä€§dƒ3qlù\Z\0õW¡y<.,9º\Ïw”\ç‡¦\Ğ<\Îk†	Uğ\ŞD\ï\á\Ô\rÁ¡£]<ºv®\İÄˆ¦Ff]0¹S\'2kòR%n›\\K4ü.°Aÿ\Ã€+&sw[@\é£Kl£ˆö\İû\ØĞ¾‹5[;8\Ú\Ó{\Æ\ÇY\æº+œnhZš‡¶}©\ä[&\ã\Â\é\îò\í‚\×_a]¹Qş?F¯\î9\0/V\ÈucQt\ÊVÃ‡u³j\ÃVm\ØBC]–9“\'2w\Ú$fO\àe\îIµŠ\"#Jüğ¿m_6;óÀP0¤Ÿ(\ç\\´²İ¾ü\íP#ñW(†lÙµ‡5[v°¾}\'¹\Âù·£‹…\Ø\r\á57ù¹¿}&¹\Ñ\Ópa‘T\Î\ßTœ(İ·‹a5Œ[¬¢÷¦_ÌˆŠR\Ù3w\r\ì\É\åyjóvÚ¼L:\Åô‰\ãX8}\nó¦M¢>\á-‡Zú‡™û\ï[R„¡—”\ÆWqü*µ\àWªFO.Ï†¾«ü-\Ï\í¡\rôg1~¿\Ä\ÍMU´\Û}[\ï\ŞHP<ó(K9Y*MnÜŒŠ.÷;—j*\Îú¯¿…b\ÈÆ]l\ì\ØE8&\Í\Â“Y8}\n\Ã’\×d¨ \æ?f©ğ›C=È€+§¹-+\Ûmp\ÓP%Õ¯³«›õÛŸcCû.¶\í\Ş;¤a¸T&K_\İŸB`D•d,H\Ñ;n\r{7\àŠ\çu)\çÈN”®÷#†W\×{s^Î‘\ÊüûEFû\Şı´\ï\İ\Ï/{Š‰£F2g\êD.™1•\Ñ#†—!hu)*l÷PY\ÆıK\ç\Ô¹÷uIn*9\ãk\æT\0Ôª½G\ØØ±“\r\ÛwÑ±w\ÉN\×.H‘ih¤\Ğ\ÓU¢#–ßˆ¦\ê»\ÏüB£ Mk”5•°¾:\æCœ\Ğ<,^@¦¾iÈ·NÌŒ±óÀ!|r-cG63w\Ê$\æLX³+\n\na\â¯ş÷õR¥$@¦\äó|(ß–_R1fÆ®ƒlh\ß\É3[:\Ø¸|›\Ñ44M\r\Õs\Å{²(\Ó@n\Ì\ê÷=K¹/\n#&P\æw9\ä™\Ä\í@Csé¿‡û:°¯ó=½‘MÃ˜7us§N\ä\Â	\ã‚øW‘™¶ş…CõM©•\â@%)\0^2Áu­\Ün\ß\Äñ\ŞRO*\ï\Är½µ[w°f\ÛvW¦¶±™t¶b¾ò÷°ª¾.CPÅ—T\'\Z\Õ\ØV¶\×(6$?¢z6\Ş9Y&\"JQ«¿]rº®lcy‡\ë;½°¼°±¾\ÙL`\áŒ\ÉÌº`© \ËZú\Æe\íÿ\ÉJ¶®$0¾9şMŒb²yg\ß\Ìı\r;\é\ÍWğò	\Î\Ñ\Ø2#{ª¿K:U“\İÎ¥¯QPlç®’;\Ê6’]İÓ© À°–ÿ\ßŞ™G\ÙUUùÿ{\î›\ëÕ˜¤R	™™!\à\0Ap\èn( b·\"Á\îv›¦€¶ş´»\í¦´\ÛFDH€ETD”€¨$•2@2U©J\ÍUo~w:û÷GU $5¼ªº÷s\ß;Ÿµ\\Ë•÷|SU\ï}ö\Ùû»\'y\Ú9‘\Í\ë\ït„ƒAÌœ\\‹Ù³¦\á¬\'!â£Uü³v\êa\0\ç\Ïd;64\Ò*\0\ã\Ô3\Îs´rwcö6·B7-Ñ’W\"-ƒ•—\Û \è“.f\å$0\Ûr\Ô(ˆa\äkO$7¦	\0²# #\äò\é(\Ëz§£\à¹@\0\Ó\ë&\àŒ\é“qÎ¬i(—¸£ÀT\Å\0°ü’3£»œz˜£\Î<\ÄT\0 ‰L{·bgcönƒMòE\Ñe\ÕuH¶-cHBAù3\0G1j¦8f\Ô\×ip2( ¿MÀAZYX\Ç\Äc±lû[Ú°¿¥\rK\×mÁ´\Úñ8c\Ædœ5c*\ÆKbzuuú\ØÏœ|£Ÿh­¤‰hp’“\ÏUŒœT»šZğöşÃV\î»E¸¬¡X\\\ê‚À€$ı\î…Áú‚Lô1|Oƒ>axH\"ÿƒ!=KŠ\ÅŠÉµ±¥¯¨¯½pÙ†­¨­®\Ä\ìYSq\Æô“p\Òx±6Ëœ“\Zü´V¤vò\0s\æ0s}#=Ê€ÿtò¹Š\Â8:h\ç\í‡\Ñ\Ñ\ë¿)cñš:ô\æ\Æ\Ü\Ú\ê\Z²o.\'À´¾Î€¶\İĞ¬ÑŸ5j¦Âú§·\\ö:²š:\Ñ\n¦£7‰†M\ÛÑ°i»ğE†*ş3‡9z¿\åxN/b\àÿŒ0¾@\ŞË¤\"\á\Ø\Êı\í‡#™ñ¦r\ß-‚\Ñ8Be\å0³rN™öCzùx(D¾\îT\ÄZwƒ\Ù#{w˜a–OpI™;%®n—U •\ÏG¢XFpª‡D€¥zÿuMÿ.\0\ï?•µ¯o¤?0\à\ËN?[\ØÄ±÷p+¶8Œ]MG\Ó\rÑ’%^S‡\Şl2º\Ú>}	õğŒhû°\íš\íX%Œ\Zÿ\İ\äÜ\Ú+b\İı…\Ì1±HgL›Œ³g¹˜W\Å`OÌ\ÍZ~ª+U=\Z\Ã\İDøTK #\Í]Ø²¯\Û4!›]:\×#e\Ç\Ëad\Ü3\Z-†£¥¯…o¢û‡5\n\â\áôñ³\àÇ¯¬?£H¼¡ˆ¿ŒŠ\n!§Ø¼÷6\ï=„X8Œ³gMÁûN™uµ\Î\\*ş@²ºñ`W€9\Ó\Ø\Ö\r´À\Ån<¿T0-›öÀÚ·÷ ;)gZ\Ü\r\â5“`fR\Ò\å\0K\ÎÍ¥P\ìX%ôq\Ó\é\Z\Üs!\ä\'œ’8•>2şŒ€Xuqœş‡\"gxc\×¼±\ë\0j«+ñ¡³NÁN‰phôÛŒeJ½ö1¼ü7gF¶ºñl7ûzB\0£\"Ó±~\ç^lØ±¯¨OûƒG.¯‚Nˆ–òd=]+>\Ì2N`\Ä4\äkO\Ã\ŞsSÂŸQ¸¼\ZÁHi•Duô&±x\í&¼¼q.<ûT|\äœ\Ó‹Œü÷J7Kşôb\ì^·\íZ\00g\Z\Ûx;A8Ó­5Š\rÃ´ğ\ê[;±ö\í\İ0-ù\İ\ÌÜ¤¬fôL\Òu_û‘P\0\Ğ\ç\å\Ïl¡t\ç{ş<?~&xØ¿ij\"’\ïsÃŠ\ç\î4è¦‰U[v`\İö=¸\à\ÌSñW\ï?\ÑpaÎƒ}§y>ÿ\" `Ç«§^p\ëù®\0Œ1¾¡‘\îğ¨[kD„-û\Z±l\Ã[H\ç\ä÷\Ä÷‚@(ŒHyô\ÔØlœÂ´l˜\Äó\0\n\Å7\Z7\ÈöeYŒš)°\Ëü=\ËK\Æ\0-R^\à(FşºiaõÖxc÷~|\ì}g\àÃ³O¶`P\İı`\ìz\Æ\\ûF¸z\Ñ\Ç\Úñ8€F7\×ğ;M\í]xğÙ—ğ\ìªõjó?²\ê:OıÒ‡ƒˆ¤°Nv\Öw\â\Äa\Å\ÇÃ¬ğÿ)U¶\0€1†¸úş½ §X¶a+~ö§e8\Ü\Ş5\è\×\Ù\\Mı¨©*ø½›+¸\Z\0ô›¸R½\èw,\ÛÆ²\r[ñ\è\âh÷¡iBaD+ªE\Ëx©´¿½\ŞÓ\ÚÛŠloq)\É|0¢\ã ı3h\ÇK\Ú{“ø\Åó\Ëñ—5oT\êô\"ü\Äi\ãŸ\ãq½\Ô7\Æ#\0:‡ı\Â¢¹£ıiVo\İ	*ñ;®\áˆU×I4€&™‘{`QÁ!ÿ\ç?¡\ë·D×½\Ã\\·N´¢1Ó›–\ÈFš1ÄªkE«\ZğÆ®ıøÙŸ—\áHW\Ï;\ÎIştYF\è1·qı\ÍúşI,†ÿs{¿ğÆ®ıxtñ\nt&\ä\ës—‘@0„h\å8\Ñ2\Ş!™ö\0@†ô\Ã#ñ\Â\n€dX\èşÕ“\È=³H´´1‘”(;«¯NÿÒL\ã\çY›\ŞÁ0IF0OaÀ‚\Ë\ß\Ï\\h=9Z1ôû…EŒe\Ûøó\êøËš7`K\ëV&\'±\êZi²\02m2£º»øñO‘Ù¼ã¸¿ $—­Fú¿\0I\ØK_‰”Á\Ó4Äª\Ô\é$\Ø\ÄÑ°i;~·l5Ò’]\å ‘\à^,\ä\É[u\Î),\Â}^¬%#‰L<·o\î–{Ü­¬h \"•b§‘%\á\ã+\0~p?º|ô–öA¿&³q+’ÿO¥²rül\"\ã \å,#\Ûv\ïÁ‚\'~‡#¥{kLÀ\İsg1OÚŸ<;V1P‚Y€\ÎD\n.^¶ny\Ú\ÙüH¬bd°¦õ\ë€ùú\Zt\Şı\0¬%óûš\Ğs\ç\İ\à\ím(s9²31‰®¬üq–‘ƒa\èxô\Ù?ao\ãaÑ’DĞ«E‚]™{\0”b ¥«¿\\¼	Ÿn\Z2G‹w¨\ë•$\Í\\0ı\Å~İ¿^\ZA›œ\ÑŞ\îŸ,„½w·‹âœ¥7)¾0  úşG…™w·-<¹t	¶\ì\Ù+V”\Çxyú<\0€\Ò\Êj\ë\ÄcK\Z)A+_·EÅ»\Ôuô\ÈeO<Ü²øù£\ïû;Eç½ ³şM\Ô9O‡\í´~÷+\Z²mX\æ{38\Ä9[±M­ş\ÊDn=ôô\ìi\00\ç–`À/\×AkwO.[#1‰\ßÑ‚\âOV­ş¸Ê±z“\èº\ë>\ä\ß\ã\ÓDú±\ß ñœkn¤\Ñ\Ô:¸±ŒWC\â³T~\Ä\Ğ3Vşs\ÎñÄ’\Å8\Ò\Ñ\á½(¯!üô“§1O£X\ÏK«cQ,\0P´!]W2\ß,]…œaˆ–Rth€h	8\Ô\Ú)}‡’q¸\İw\Ş~hğ©#‚ù\ÅK\Ñı›\'ÁmÉ¼öû\á\0Úº\Ägg˜¦ŠÿF\n·-\Ø\Æ\àfT†a\à‰Å‹\Ñ\Ñ\ã\à{”\Éd‚®\rı\Ï€\ÙYš1ü\È\ëu½ ™\É\á\×KW\"“/g5\é`.¨aš\èÉ»j\Î5&2olA\Ï]@=\Îß´™¯½\îû\Ï\ÊPl÷^š{²°mñ7‚jñ)\Ö1wÿƒ‘\Í\çñ»Å‹‘\Éù¬§@ô\ßW\Ïaÿ\ã„4WÇ’xÀ~k»…e\Ûøı+¯©‚?\á\\‚\Ó\'v5¶#/\á{>ù\ÊJ¤ñ »—}²w\îB\×O\Â\ê\ìvm‘’±İŒ7\0I„ø	n[°\Ì\ÂL‰t\nO.y¦O}*‡\è²CB†\æ		\0f\Ïf?±¶[,^»	\Í½‹Ë\ã\äyğp;ò6 Ë¨rnY\è~\ì·\È-ú£\'\ã“yk+º²\0úAñs¾ş4\ËqGl\r‘\ÊVœˆ™™#jKG¯Z\å’\Z1\á?\æ\ÍfBîŒ…Ù«Í™\ßc…’lÜµ_™ü¸\rQªP<­}&%\Â¾v*ƒ®\Â\\·Á\Óu)™D\ï\İ÷!-°CÀ\äx\'s¤M\à\Û\Ìg¥¯‘\Û\Ôa[#\ß÷\ŞÚ½on\ß1üúƒÍ¯øƒ¨Å…\0Œ1®q\Ü&j}§h\í\êÅ’µ›D\Ë(zŒlJš´–\Öw]\ÊÒ¦\'‡\î1· ëŸ‚\ï\Û\'F€i\"#¨CÀ& {Ì¯C\Ë£e½„[&Ì¬ÿ\\=‡\03?ú\ï\Ó\Ò5«‹\Â-sü¿zÆ„#„\Z¬Ÿ?“- \Ñ Øœ\ã\ÙW\×+o\È%\åxÁ@û±“\Ë\0düø³[·£÷\î{Aİ‚O¾G;~\í]‡\0Q_ö\åØ¸«K\"§\Í|R\ë™±Œø\ê%,\ÛÆŸ^y–$‡‚Qò—\Ë\Î-)@ø„›ğm\0¾¬\êhØ´­\İ\â[Š=€™“\çT•H¾·U\×\ä}w\Ñ^‘|e%R>\Ê\És\ßl®\í\ïpy¡ÿ\êå¸¬K*%\ÏtM#›†‘oJ$+DSûu^GO/Vm|\ÃEB°x€ÿ›h\Â€‹f°\íü\\´‘\Ò\ÜÑ\Õ[wŠ–QôØ–‰LW‹h\ïA\Ï\ça·\å¹ûE}\Å~OxV\ì7Rì»\Ğu—»y°û§\ë†İ\Ëq3\İ\Ùn\É\Û.*KÏ‚\ê\èymóf¿š=x\Ùi‘\í¢E\0\0 \Â\í\0|s”&\"<¿öMp	úÒ‹\â6’­Ç”*t\âû›ZOøóŒ\İw7\ív*ƒ®…\Â\\·Ş‚·¶¢ûŸ\"¿\Çù._÷ı\ïx¶\ï;,]@\ÄmÉ¶Cmt\Åq\î\È\éÿ(œ8¯Z’\ì\ç?=œ‚?-$\08o2\ë`€ßBØ²÷Z:Kb¤0ˆ\ÛH98¤C˜H\Ş\Ş?ğ¤²Œ\åü^¤nA×\n¾WP±\ß¡L‰{@z½s\éY›¿f\Ùu°Ù±uœ\Ä\ÒsH¶©\Z¡w0òI\Ç? -Ø²\Û?C«\0ª¿\ì,&EQ“\0\0¤¦\á>ø -Ğ°,¼ü\Æ6\Ñ2Š\Z\â6­a\éòš*\í;4°ñG_&À)²[·#q÷½ .9\Ú\Ü\nÆ²y\ìqG:8i{p¯¸‡O\Ì\ÆÈ‚™Ïª  n\Z°]ºªy\åõu0ıq\åò;zP´ˆ£H\0\Ìe\ÌòC[\àš­»’\Ğ\nµXxgó\ÏË»ùÀ\á\ÖöAÿ\Î\" \ç@xñ\éŠıFô7· «[£î·	H“U9¶-SF\Ì|\É\Ö%Œ¼{…š™\\\ë¶\Ê0c„[\ç\Îe\Ò\ÜiJ\0\0}mxJ´Á\ĞM¯¿½G´Œ¢\Å/›?\0tv\İv¦s k\r\çp>8Yİ‚±q“tw\Û#\"F\èk_…¡‘2O,\Ş÷mş\Ãm›\İ\İò_\ÇõeJ7°ô±µı\Âk›7#§\ËUú^è‰¹g…\ZD«8©\0\0\à|€–oÇ±~\Ç>\ä\r_¤™|‡Ÿ6\0\ÈfÓ°‡\éA6úO¯#\ÙøL$MÀĞ‚~\ã\ë`\å\åcT*\àµóÀ&\Õ\è\Û\Ä\ÓV\ßõˆ\ÉŒ8õmüI³/‹2Ü·.¯\È\çı‘‘+\Õ €8‡1ÓŸB\É\ë:6¾ı¶\ëëŒ’±\ĞwE‹8\é€MaMŒğß¢u\Å9Ö©Ó¿+\çHñ\Ï\æôi~{\ïÀ…€\Çr4…²ú6¶^ıvÿ¦—²\Şk/\Ìjjü\ê—Á4\é>¦\Ã¸\èB.¼\à„?7yß¿1i¾d\íwÿ,iõmü…n‘›wôUø\Ñ \0%˜ù”g™¬\r[·\r˜¡ş\Ò3˜tÕªR¾YR\Óq7›E\ë8–-{\"\å×»X™!B²­¦\Äƒ±yg\áó\ìşº€¤	ôöot	H˜}nB\íôÓ¡]ı)U»6y‚\×~nÈ¯!ôeFLı\n£\Ù·\ì:8\Z‰B1óY$\Ûı}½S ¶ex: )\Ëb\ëŞ½­W\Ø\Ğyzğ^\Ñ:B\Ê\0`.c4\Ü\0ñ³V\Şa\ãÎ¢š^,\r™¶O“…½‡F\Ğs\ê{ÿ²/½\ÚyõZ\n!ø\å/\á°\'\Ë\í—dğH1²)d{}i`S0D#\ë½#\â\ÆmRš6øõó“0-!i\0\0\0Lc\ë	xX´\0h\ïM¢¥KşB#¿a:r	¹+¸‡¢Ù«\ês\Æü‡¿›<Ù›õ\Æ@pŞµ`S¦x¶^[‡\Ï\Ú#!\×\Ûn\n™\ë	V>#\Ä©¥£m]R´Ùƒw^vf\ä-\Ñ:C\Ú\0\0\0¸\ï1@ø½\Éf5\ê\×²‰v_§AÉ„gòY$‚\Ğõ_b1oó\ÏC\à¢=[\Ï\æ\é”=÷‰x\ßg !Û‚iˆ«\åŞ¼S\n›ö]ˆ$Z\ÄPH\0\\t\ZK‰õ\àœ°e_£H	E	q#\í÷\çá–…İ‡¼›SÀ&\Ö\"ô\å/Œy¶f¡°‰øü\ç=]sË®C\à>·\Ú\ÕS‰¢\ë\n \0F.9úXØ¶wH¬U;g\×ÏÅ¤.“:\0\0€f°§Áğ´¨õ\Û:‘V\Åc\æR¾ª\ŞŒõoy[p¤Í\à—{ºæ°„B}\í+`Ñˆ§\Ën\Ø\êÿ®\"Óƒ9/±õ,lÁ®|™\\Mmm\Â\ÖgŒ=8÷Œ\Ğja\nDú\0\0\0X\07AH®lO³?‹Œd\Ç\ÒıÑ»=;d‡W^möl\Ï\×Œ\à\ç>\ç\é½ÿQv\r2ÁoXzñ0¸m{\Òó_;ˆ*Ü¦\Æş]\Ğ\â#\ÂÀœ“X\'c¸U\ÄÚ»˜ú¦;¶U\ÅO\ÍGœ2C\è\Ë_«\àı\Ú\Ç8\ïƒ|\ä\"!k·µG=7ev¯+`\æœö3Zö6\nººeÚ;“ù¢µ\É\0\0\\0ı„g¼\\3‘É¢½\Ç\ß÷Ô²R,÷©Ty]@º3C\è†ò<\í~,lb­\ç÷şG\éNe\Ëù\Ï;b 8\ÇgÁÒ³Rö½½H¦½\ÎF\Ğ—œ\\\âñ¢£\Æ7\0\0\Ø6n\àY\Çş–\â¬Ğ•?º\Û\r6¾-fL/««Cğÿ(¦(0Bğ«_‹E½_Àš7wJs\Ò+\Zóÿgl–$©ÿc9\Ø\â]‘.€\ÆB\Ò´;_ı\æ]t2k\ã\ßğj½f÷Ë‰–\à·‰s\Ó\Şÿ~\æ^\ìùºÁ\Ï}\ÚÔ©¯{”·F\à\Â(;Z\ĞßŸ \ç’Rõ6ñ²†‹}c\î\ÌW\Æ&¾\n\0\0\à\Âi\ìYFø¹kµt*ó·F\ÊDKpŒ=›„®ü\ÛOC;\ëL\Ï\Ö\Ó\Îû ùˆg\ë\rÄ&OOv®ğùgÁ\Ò3\à‚«ş£¥Ã«:ö\Ğ%gÿ\ì\Ñb\á»\0\0\0\Âm`p\Õ\éÁ\æm\İC|UŒP,.e?ûh\è\èôk\Z‚_ş\Øøñ®/\Åj\' (\è\Şÿ(¦m£§§H>›Œ!‹‹V1j¸mÁ\ÌK9¼\0\Ğ\Ş\İ\ãúp vdÒo»ºˆKE\rsNb\Ù\r\é \áu\0®˜·÷&aI¡šŒh Â±8Œ¬|÷†#\Å2M¼½¯	³O™&L‹\Çú\ÚW`şò1÷\î\ÆC\è\ë_v\ï”\r[÷‚\\-\ï\á²r0- ZÆ¨ \"\èÙ„Ôµœ\Û\è\ì\íE{Á±\Îıı\Õs˜/+R}\0\0À3Ù¦õô¸Ë\çw\'ı¿1\ÉN$^S\0\0¼ºa‡\Ğ\0\0\0Ø¤:\ãW\06Áı,\Ãp¬{k·h	‰×ˆ–0j\Ì|\ÊXw\"\áZ\0@ \ï]zFx‹+÷\0^ôsÁ4\Ü`™\ÏN¤\äMk\áx%P$\İ\0\Û÷-\Ô\Ô\ä\îiŒ\Ô,\Ş|g\Ï±5N¡iDâ•¢eŒ\nn\Z¾1ó\êN¸\Ö\Êı\Ò%g„¤ó[(¾~û2Æ¸m\á‹\0wc\é\Íø2£\ã+˜¦!Z\î\ßĞ±HaJ\Óx\Èı5‰‹Atv\Ê1\ém¬„+j|YCœC\Ïù\Ç¥ÇQAü\ncL\Şûğu\0\0ôµ‚\á«pxôD\Ê\0xB¬rœh	`\Z:öl}Èƒ\0À‹ c6\ï<\0Ë”³\â|d0\Ä*ü÷»\ß\×ò\ç¯F\é¬\ã™\n\"b_ÿë³™\ï}\â}\0\0À\Ó\Øx\È\Égª@\ŞGŠú·\núX–¯\Û&nñ|\Ô\á¾qµ·yq©ß†\ro[\ÛIB±r\Â\â\\G‹•Ï€›ò¸ıB\Öù\0\àşK\Ï\n>\çôCEP\0\0\ß\à\Ø\ÛÁ´ü=f\ÔOD«\Ä–9Á\Ö]b\îÿ\ßYˆ@‡\Å\Õì” \Ö\Â	bUş;ısË”º\åo0²¬le‘\àw{ `Š&\0ø\È4–C\0\×\0p\är\Ê4\å¯n-\Âñ*\Âb[Ëœ ­­\\Tj\Ô\ËÔ¼W\r`šºŠ\àş?\"«-cD\çĞ³½pø¦\Õ\ç|\0\Ò\àŸŸ;‹Mz¸h\0\0¸`\n\Û\Åª0]6P¼«?\Ùn¬Ø–‰u[\Å\Ø“‡›2	ªX¹q8÷ÿç²¬º\Ö_\ÅY\İû‹SF@öµ\ËN‹lw\äa’PT\0\Ğg\à±>G]xK´¼\ZŸ{¢À*wÔ¹,\Ğ\éaBG;ó¾`\ífW\Í?=A…‰W‰–1\"L=%Õ”¿‘b9ñ.\'\Üs\é™ÁEc\\]\0\0\0s¦\á?A\ÓHF.±»UQ\Âb5E«3»÷{:&s\ÏEdŠ¡ÿ?^]\ç«Ó¿m\ê0óşn‰¦1[fÀ\ÚNü7‡\äHEQ\0Œ1¾\0@\\U–b\ÄD\Ëk|Y},½=½Hf<>‹¸“÷8\0\èNeq§Ÿ\Û3\á\"\åş9ı·¡gıı=3m&‚Ÿ›7›ù72E\0\0Àûf°\á³\0üW¶Zª0†²\ê:\Ñ*\Æ\Ç+k·z»hSñ\0\ËVoóIN4e5>:ı!Ÿ\é|ş=#>÷‰3YñŒ<¢\r\0\0\àüi\ì-\0\ß­CQ8\áò*}\Şğú\ïª3iP—÷•ñ\Ô\Õd¼‹­\×oõ·ÿ(R†H™Ol	Ğ³	_øü»	#š?÷Œ\Ğj\Ñ:Ü¤¨\0\0¸`:{ÀB\Ñ:…Á\0\Ä\'L\éÿş\äP£w}ò\"\îÿ\ß]Û»,@s³ŸM\×\â&û\æôo\êiØ¦.Z†`\ØCs\Ï\n?,Z…\Û}\0\0\0\éiø€\Ñ:…Š–!R\î“\Ó\Ò\0z[÷xS°\æeû\ß	x\0l\Úq†\î\ß\Ö\ëHE5‚‘2\Ñ2\n\Â2u_šı8ÌšN;p›h^PÀ\\Æ¬°\ë\0ˆd¢(˜ø¸É¾ø\ÊZ&„Š¸ÿ\ïÇ«\ì\Ã\Ëk7{²0MC¼\Æu-d[0²şò\ãt\È?[¬E\Ç\ã\ß7\ìyÿ©¬\İ&\\	 G´\ÅğhÁ\âÕµ¢eŒš·w\íw‘T\èø\ë\Ü\Ó\r¤R®/óö\î®¯\áe5u\Ğ|\àoAœ#Ÿ\íõ\ÆNZ^Rô\é\ËOe\îÕ„’	\0\0\à¢l;1|@©_pù‚hU-¡°h£¢«»Iç‡¼¡\éÿ£¸|\r\ĞŞ“D*\Ñ\ë\ê\ZnG«ôÇœ=\Û*m÷S‹ó.;3ò–h!^RR\0\0|h\Z[	\Â?Á¦\Ö%cññ“E\ËDxa\å›\î®\Ñ$şF‹\\¾‚X²\êMOO¥ññ\'\É_øG€M‚[\Å0byô0F·\Í=3´T´¯)¹\0\0\0.˜Á~Cõ¢u(†\'\\V‰P™¿§\åµ7]¶\r\ä\Éÿ¹›3\á\é\0\0IDAT„¬\ß\äO\ëõp¼\áX¹h\Ãb\êiØ†¸ñ\ÎR@X0÷Œğ¢eˆ $\0\0ø\Ğ4öC\0?­C1<¦€i\Ñ2FLsstİ“%zA	ñ[n\ê\È\æu´µ{8\ãÀ!˜@ùø“D\ËKÏ•|\Å?\ê<3ø\Ñ:DQ²\0\0°v\Ìğ’hŠ¡Ñ‚!\Ä\Çù£’úX8·ñ\Òk.u\Èpÿ—2‹W¾	ò\áô¿òñ“¥/ü³MF\ÎıN©!¬³ô\à\æ1\æ¿_2‡(\é\0`\Îf\ê1|ÿö•‘\Êñ\Å\â¢eŒ˜•Ü±&	\îÿ\ßÁ%-k\Ş\Ø\æ\Ês\İ$+G¤¼Z´Œ!\á–	=›@)—A°\Ã\àÁO^ş~V\Ò)’\0\0\àcµ,`¸\n€ÿG1@ù„©¾ó8\ÔtØ±y\ä\ïA†ûÿ~\Ü\èF°m\Í-şrÿcš†òÚ©Rş·¡gJ¾İ¯<x\å³Y·h!¢ñ\×\Û\Ô%Î›\ÎZ4†O(ñ\ÑWr…Q\îS•£Ø¦‰†\ro;ûPú\ï\Æ?‚ek·Â¶ü\åE7	‰Sÿ\Ä9ò\é\ßU\Z#	~\å¥g3y\"h¨\0 Ÿó§±·ˆ\ãJ\0i\ÑZƒ©š€P\Ô_W\Ë\×:\ÛZ,\ÒÿPnlx\İ#\'E‡\Å\âˆVŒ-cPˆs\ä3=¾¬©p,iøt©õú…\n\0\áC3\Ùk |€Ç‹ ¼v*˜®ö<\äl/»D\éÿ£8y\rÀ‰p\ànä˜¦õ]OÉšú\'R\ÓıúFû^s\é\é¡U¢…È„Ş¢qÁö²ühŠÁ	„\Â}³\Õ}‚©\ëX¿u3#o§ğ\n56:VS¶f\Ó˜¦¬\Ø\ã5“\äu¬$‚\é·üóıtF\ìšR4ú\0Àù\ÓÙ‹§L›ôˆ¤ñ¼@´jBeò­e\é«Î¸RW\'‘°p9“uw9ò¨ú^yA8Vh¥¬©‚KÀ.\áÍŸ1à´™³{Vğy\ÑZdD\0ƒ°\à+½\á\ÜS§ÿRr\Â\0T\ÖNƒŠ–R;÷84\ĞF\àô¿aqH\Û\Ş}ÿAQ>Q\Ò\Ô?F6	\Û(İ±\'Œg\Î:ùñ‡n¹òz\ÑZdE\0Cğ\ã/\\ôõ÷:\ã\×~¼\0X ÿùBz>‡\Í;ù9R\0\Z´­Ù´†6- b‚œ(\ĞsIXFi—29k\ÖšÕ—D\ë\0\Ã_¸ğ+\çœ:ıòo1¥I8Vh•?&®=×°al H1\0h0œ¨p\êª\ÄmbÕµr^A`\æR%\ï\ï?û”S—<4ÿS×ˆ\Ö!;*\0(€;¿p\Ñ5\çœ2\ãO¢u(&>®ÁHL´ŒaÙ±g\ß\Ø\Ğ\Ù\ä$~±\ç²@\×\è½û‰€½û:§\Ç%B‘29‹P	0òIXzV´¡œ}Ê©/=pË•W‰\Ö\áT\0P w~ñ\Â\Ï|ğ´™/ŠÖ¡8\Æ4TNœ.ıÀ |6‹õ\ÛF\ÈXıc\Ğø\ê;¡ë’§­5\r\å§\Éw\ïO€‘KÁ\Ò%=\à\Ü\ÓN}\åÁ[®¼\\´¿ €ğ£ü\Ğ\á`à»¢u(ND…7Y´Œay~\Åú\Ñÿ\Ç2\ßÿ÷\ÃÇ ñ…Uc¼\"ñ€ò	S¤kù#\0F.	\Ë(\í“8şÁı7]y™h~B\0#\äOß¿\æ\'\0şU´Å‰D+k¤Ä²k\Ï~p>\n+V\"P“\ÌqššF\å3o\Û6ö\î?\è¼‰VT#*\Û\ïf6«\Ä\ïü|ÿ¥Ÿ\ÜP/Z„\ßPÀ(XR?\ï\Æ\è{¢u(N¤b\Â\ÂQ\Ñ2\Å4t¼òú\È\'R{ {z\0ò9 £}\Äÿ\Ù\ÒÕ›a[¦‚œ!\">aŠh\ÇA0r‰R¯ö\'0úv\Ã\Â[~$ZˆQÀ(Y|ûuwø*€’ö×”MCe\İ©­‚_\\=ŠJw?\Üÿ÷3šZ…—\×\È[ı¯iT\Õ\Í\0c2ıNôL\Éoş6]ß°`şİ¢…ø™~£}Ç’úy¿£\Ï¿q¹„„Â¨¨YıjB\Ş¡;\Û!y\ÛÿN`„ZsyM‡[\\3V\âµS \Ét\ïO„|:\Û,\é×\Î×­X8ÿ—¢…ø\0Œ‘%·_÷Œv\Ô(a©\Ç+« ZÆ€p\Û\Âs\Ë7\à?\à@³\îÿû¡¦\Æ\Õüñ\åu\à’N©+«©E$^%ZÆ»¼\ã\í_Ê›?K‘Æ¯\\q\ï-ÏˆV\âwT\0\à\0\Ï\×_\ÛÀ4\\`ä—Ÿ\n×ˆ\×\Ô!“stğŠu#w\Û\Ö\n\Ò}ô\Â7t ­µ\à/_µn³‹bFO(V²ê‰¢e¼G>\İS\Ò\Şş`\è\Æ?±ò[Wˆ–R¨\0À!ÿ×¼70F·…c0†Š\Ú\éĞ‚!\ÑJN ­µ\İ\ÉtA_+µı\ï ª¹µ«.«9Z0„\n‰úıÉ¶‘Ouƒ\ÛòJzÀüM\Ã=ó_-¤XP€ƒ,®¿f¿\nü€\ïn¢ƒ¨¬›&É‹ü(D„g^Z[\Ø\Ë<\0h\n-üÃ’5 Q´\rº\nc¨˜(\Ï?·,\ä3\İ I¯I<\á€f\Ó_­Zp\Ë\È[hƒ¢\0‡yñ?®9b—\0xM´EÁH\Ê\ÆM-\ãÖ¾±mø/\âtø°ûbœ¦ùp_\í\Â0l|k§bFFù„“Š\Êqu\ÄM£ó…wD±@x=^´üşù*»\ê0*\0p\ë\çuû8–ˆÖ¢\è#V5\ÑJ¹†õööbÏ¡#C~\riL¦}\rhúß¶mo2©”G‚\n#Z9ÑŠq¢e\0\0,#‡|¦wT\ÆJ\ÅcX¤k\æ%/ıôFU_\å*\0p‰\ç\ê¯Î–OØ¢µ(ú(?¡¨DÜˆ°\è\ÅaE>¼ÿ?\Êpu\0O¿ø\Z\Æ<>\ĞAB\Ñ8\â\ã%°“&À\Ìg`d“\éû\ã5\Ä\Ø}+ªº>¿vÁ·J\Ş\æ\Ğ-\ä¸\ä*RÍ›gøŞ•?ø\Ã>F\ì\0òU£•Œ¡¢n\Zz›÷‚K\â:·uû\rQk\æ\Ãûÿwh:|ø#ş\ç;v\ïõX\Ğ\àh¡0*\'\Í_+B]óµÀp\Ë\Ê7ÿL´bGe\0<\à…Û¯û9\ï«ı¬T…#h ª&Í’\Æ)P\Ïg±|\İ µ\0¶\rjnöVƒPs3`\\¸¶tõf˜’´6²£N‚§IRIoş=¤ñO4,¸Emş \Ç[°XZ?oµ\r|€|UO%F AE\í4i|Ÿ[>HWSs3`ù\Øi\Ú4ûj`\éª!¹P1qªğùÜ¶Ou•t?û9iU=şŞ¡\0y±~\Ş\Ş`,ò!\0Ï‹\ÖR\ê„ã•ˆ\ÕÔ‰–\0h:|½©\Ì	N~Nÿe€:€\îd\Z\Í\ÍrXÿ–ŸŒpY¥P\r¶©#Ÿ.ñ6?\Ğj_¸j\áM;D+)%T\0\à1ù\îß¦\âg\ã\ïTq xÊªk¥Lœ\ã\É%«Oü\0e  \æwÏ­‘ø¶¶Hy\rbU\í¢	0óY\è\ÙÒ®ôÃ£1—5\Ü}ƒ|PE\n\0°h\Ş<û…úk¿°o\0(İœŸhCù„)E\ÊD+Á\Ú7ó7\"}\î+¸\Æxı\Íü\\&‹£¼ö$q¨o”¯™O•r¡¿†\Û\Z\Ürı÷Ï—£ ¤\ÄP€@–\Ô_û\Æ\è\n\0*ò\Ó4TLš)|\Ú[:™\Ä\Æm\ïúœU@\ç+lhy·ñµ-»\Íf\ìP§\ïK\ÜF>\İ]\ê£|C£‹\Ür¯h!¥Œ\n\0³øö\ëV°F´–REP9i&X@lø³/\ã	P÷ÿıkü\ìp¾.£‚¨œ4S˜\Ío\ß}¸\í\ã\âÎ±³2@ö\å\é/\0HÀõ\×Î¢öb€~\0@ü\åh	EPY7CØ©\0v\ï9€¼\Şw#\ä\Ç@ƒ\Ò\0¤²98\Ø(Nc¨¨›@(\âı\Úı\æ>z¦\ÄK6\çO ü¸¶¹\î\ÒWî½­M´…\n\0¤¡¡~®µ¤şºz€ı-€n\ÑzJ‘P4ò\Ú)€ AÛ¶°\èÅµ\Ù\èú	j\é³3~rñjpa•\îµS…xüò™˜y±Wba)€\æ5\Ü{Ë¿-Z4¯î¶Š\0HÆ’úkŸ·‚ö †		!R^²\Zq3\àW¬\İTğ \ß\Ğ?\ĞhÍ†·„Iˆ«\ÒñÁmùTx	÷÷lWÀ\æ5,œÿ´h%Š÷¢\0	y\éû\ß\æh!J¹FXe5­¨²voOö¿Y|O÷¼¹©dR\È\Ú\Ñ\Ê\ZÄªk½]”\0KÏ–|?=ƒ\Íy\åşù\ÛEkQœˆ,fhŠA¸ªş©Oğ+\0bv¤R…‰¶ƒ0³Ş§m¯šX¯–×¦ñpRÃ²\ÎÍ\Ü&\\VÊº™C[p\"‚‘MÀ6Kº³-A W.œÿ¤h!ŠÁQ\0\ÉY\\?\ï/\à\0TÅ¬—0†Ê‰Ó…XÄ¾Ö•]Dy“\ëz²¯Œ\ÄP1qº§›¿mÈ§:K{ó\'¶6£6ùQ€x®~^#+¿¸\ß=°¸†Ã´\0ª&Í„ôvˆcMØ-ók¤\ÇM Fe\İL\ïü­òO÷€Š©~cdX\0~P\Û2ñ\ã\r÷\Ï?,ZŒbx\Ô€\Ïø\äŸ¾œÿ\ZÀ¢µ”\n\Ü4\Ğ{d¸‡ƒyÎ‰i¨Ÿ, ]\Íş½Y\Çnİ»MQQu\Ò)xd\îD¶=›·\å1-†šÍ¿°ü¾[Uñ²P\0Ÿ±\ä¿>·.€\Øy\0{\0ª@\Ğ´ş\Ó$<!¼-\Ç\Ñhøÿ$y@\çnşL r\Ò,o6ÿşB¿\\º»¤7zºö>µùû•ğ1W\Õÿ\á2{Àt\ÑZJ3—F²õ È£Á-WTqıo¯œ\æ+R\Ş\\g0\ÆP9iB±\n\×\×\"n\Ã\È&K}|o;İ¤\Úûü‹\Ê\0ø˜\Åõ×½L0\Î%\à\ÑZJP¬\åµS\áU\ÜÜ¶õ±k\\\Æ&¼–öª–¡|\ÂT÷7l#‡\\ª»¤7Æ°ˆ\Ût\Úüı\Ê\0	Wş`Ñ• ú8+\rr½\Èt·z²\Ö\×\'„pe¥\ßú±ò\ç^w{“\ZŸ\ìúh_u\ê@h%ı\Ë\Ê7?+ZŠb\ì¨@‘ğ\Â\í×¾€0>\0\à\ÑZŠXu-¢Í‘_š´=»rp`YÊ›¢\ÉXõDw7,#‡¼:õ/Šh\ælµù*P„\\ùƒ?\\Íˆ\İ`†h-E\Ò]\Í\È\'{\\_\êö\ÉœóW¬şf–\ã[\İï…TÔ b\Â\×zıÕ©\0\ØA0ş†ó_­D\á,şz«(\n\â…Û¯{.€\Ø\Ùı\ÓKù\Í\åŒ¡|üDÊ«\\_ji\Ò£c—&\İOıG\âU\îmş˜zùTW\Énşpb\ì¾p0w\Úü‹•(r>ùÃ§\Î\ÇC\0>*ZK1BDHµ‚‘K¹¶†\Æ˜Am\Ğ\×V“0¿)\ï\ê\\\ëPY¹kã›¹e@Ï¥@¶ÿ/§ \Ğ[N7ªÖ¾\â\Æ#›,…(ö¬XÔ¾§\á©\ÇNŸ»½‰€2 L´¦b‚1†py%\Ì|\Ür\ç\ÔK\0\"87æ\ë3½v¹\ØûŠ–õ»ü9¼ù‡‘Kõs\ä†Q\Ò†\ï±\ê\î\ëW\Üù½C¢\Å(\Ü\ÅG\n…#\\u\Ç5¤‡\ëº\êú\ÇQˆ\ÛH9\0KÏ¹òü\Ê\0\Ã\ÃÓ£Iş‰58\áŸ\ZóH»´#QTM:,\à`0D€m\æ`\äR¾,¸tb \ßjÄ¿óÊ½·µ‰£ğ\É_\'\n7¸¢ş©iÀC\0\Î­¥˜\à–‰\Ş#ûÁMw\îŒo®\r\ã\â\n¹³\0/§,ü¬ÃLH0A\åI\'C8\×\ÉmF.\åZö\Æ\Ğ\á\æ\å\æ¯­D\á-\êX‚,­Ÿ·ºmr\Ïy\ÄØ·¸_\Æ^\"hÁª\'ŸŒ€KÃƒş’0¥>¡K¸cü£…Â¨œ<Ë±ÍŸ8‡‘M\"Ÿ\ê.\ÙÍŸ€n0\ÜV\Û<\é\Ãjó/MT Ä¹¼ş©q°\ït\0o¦§9¶i qd¿+‹\Ì-nµşiÁ *\'ŸŒ`h\ìÃ‘ˆ–ƒ¥g@%z\ÏO\0\×@OP ò­†»o\è­G!\0(\0\0W\×?5\İşƒ\×Ce†ÆŒe\êH\Ù\ïøÁó\Ê4üû$9§ş\àˆ­9g7UöeU\Âcü7`Yy˜¹4ˆÏ¨\å\Ãğ<lşo\r÷İºM´…xT\0 xŸ¬z\ßÅ€‹Ekñ;¶‘G\â\Èp\Û\ÉN\rcJX®­\Ñ\àø\×\Ã\ÈÁ•Z ÿ\ä?\ÆÍŸ[&Œ|\Z¼Dûù€{\r\à\ß[¹`ş«¢µ(\äA\0Š\éŸ4x€sEkñ3–‘G¢e¿£§ÎWqƒdSÿ¯\Ã@ƒƒSÿ4-Ğ·ùG¢£~\ÙL=\Ë\È;¦\Ëwvğ_+\ï½ùi€\É[@¢‚\\\Ç…4,®¿\î\å,j\Ï\èF\0ª-h”\ÃQTMr¶g}e\ÚFÒ–\ç]°kœúÇ´\0*\'\Ïõ\æÔ¾7—\î*\åÍ¿™1vjº\Î]y\ï-‹\Ô\æ¯•P\Ë\ÅõO•ÇoğM\0Õ¢õø3ŸE²õ c™€\ëj‚¸¶F,À“=\éq¦\à‘i\Z*\'\ÏB(2r¿ª¾¿4L=H\Ü-\á*=\à\ìN]3\î[»\à[\î˜R(Š\0(\n\æ\Ówş¹\Â\Î\çÿ…ˆ}@h=~\Ã\Ìg‘h=\0ğ±\Ê\Éb¤pccŞ‘Œc\Z*\'\ÏD(\Z\ÑG\Äa\æ3°Œ\Şø^\Üo\ê«ú\ÕÚ«(\0(F\ÌUw<Q=üM\İ\n R´?a\ä\ÒH¶td£º©6Œ¹‚^LZøy\ç\ØOÿŒi¨œ4¡\Ø6\â0õLiŸøA\0{\0°6,üf¯h5\n¡\0Å¨¹¼ş©qA\àf\ÌgÀx\Ñzü‚™K!\ÑzhÌ›\Öô0\Ã\İS\"`.\Â\"\Âm\Íš±e4\ÓPQ7á²Š\Â\Ö\å–‘¥\ç¤6Fr™6[P‘\İÿ\Ü#7dE‹Qø\0(\Æ\Ì\'\îúM<˜^Â¿˜&Z0²I¤\Ú\ZÇ¼ı×¤\ŞW&¦–wc†\ã\Çmc3şaLCÅ¤\éÇ†\ßü‰\Û0õlI§ú	Ø¯1vç„ª\Î_-ª¯/İ¾F…#¨\0@\á\×\Ö?Î€}	 \ï\08]´\Ù\Ñ3I¤\ÚÇ´™\Ópûd1\Æ@\ßoÑ±3?†\Ó?c¨¬›p\ÙĞ·H\Ü2aYX†8\è3\à3ö1\Æ~BU¿l¨¯/\İ9\Å\nGQ€\Âq\ê\ë\ëµ\r8ûSø¦2\Z\Z#“@²½iLAÀÿN‰\àôˆ·Y€9ÿ<2†\Ó?c¨¨†HyÕ€M\0¸©\Ã\Ô3%\ëÕ¾ßŠeŒ\Øı\r5KP__š\Ş\Å\n\×P€\ÂU>Yÿ\Ô¸‘_0zW—\"F\Ï$\ZCpQ<€o\×y;\Æ\á[u¼™\å~\Ä*j§\"R>@G),#\Ë\È9\ê \è3\Òô¸Àı«Ş´C´Eñ¢\0…\'|\êš\Â-úg€]`’h=²¡§z\î8<ª·`\á´(Nò¨\'°\Ñ ü\ëa}t¶¿ƒlşdÛ°\Ì,,#r MÒ°Ÿ{$¢?qÁ·ºE\ëQ?*\0PxÊµõO…\ÓŸa„ğ×¢õÈ„\îEª\ãğ¨2—UñÏµ\Ş\İ\ßn`\åhœÿCy\íTDû7À-¶‘ƒe\æKøzkˆp\ïÄ–º?.Z4¯„\')¼F\0\na\\Uÿûs\ìF€ı#€/ƒKŒ\Ñ^„Ãƒ\Ó#¨	¸û‘\î´75\é°G\Z¤0†Ê‰\ÓW‚ˆ`\Ùş4i\îwt3†\ß,z\è•û\ço­GQš¨\0@!œ‹\ë‹\ÆYù\ÕDôO\0.E‰ÿ^¶0ğo«ƒø\â8w³\0¿\ì2±$1²»y\Æ\Ê\'NG0…m\ä`›zIö\ïÀ°œ=^‹<­ú÷¢)\é­B>>õ\ßOŸ\Æmş5\0_0Y´Q\Ù’m#3Ši?›EÜ¥†€”M¸±)‘tş1h(Whš£ı\Û\Ğ\ïµ\0{lù\İ7­F¡8Š\n\0RR__¯½³?Â€/2\à\ïfWD¹’#tü‡q!|¶:èŠ?ô˜X\Ô3‚\Ó?cˆ–WAyÛ¡ $5†?0›ÿjù}·¾&ZB1*\0PH\Ï\ÅõEc¬\ì\ãŒ\Øü\09\Æ\ày€™K!\Ù\ÖXpe|e€\áÁiD5g?\Ú9N¸±1t§\Æ\"\å\Õ\ĞB%ó£ybx‰ª\ÈFU)~…\ì¨\0@\á+®®ÿ\İ‹>Ãˆ]`.\0w»a\æ3H´,xŠ\à—Ç‡pu•³ß–?öZø]wa†<%µùò\Ğğ2\ã´(üù\å;oHˆ–¤PŠ\n\0¾\åª;¨\ázøjºÀ\'\0m®\Ù\Êgh=T\Ğ=zU\áÁiQDút\çy_\å¢€‘¿ŒiˆTTA\ï\æO@–-\Ñ\Ó0µ\Å\rŞ”­I¡\r*\0PW\İñD\rŒğeDt5€«`3\ço,=‹D\ëAP­s_\ÂUe\í1ğD\Ïğk2\Æ©¨.\Ö\Í?M % öte.¼X¥÷Å€\n\0E\Çù?št¤úo8ğiö)\0³Dkr\nK\Ï!\ÙzpX›\Ü\êşZ€ğ(kÈ²A9Ùœù™0’4Lk\Ó­¬‚(ÍŸ@oli\0xq|u\×j5}OQl¨\0@Qô\\Uÿ\ÌÉ€}—¸À\Ğ\ã\ç$§/80¬‰\Î\×&„ğ\É\Ê³\0œÀu”7@9ı,\Ãó<‚\'\ì¡G8ô¥ı«¡}_‘C{\Îf\ì…U÷\Ü\Ô$ZB\á&*\0P”WŞ·$B=™1\Â\Ç\èb\0\çÃ‡…„¶¡#qdÿ™€š \ÃS\Î\0&(¯ƒ\ë&H7Nh74Áp«U\Zü5Á4\rÑŠj°€ï¾…\0`ğ-iK\'6O\\¯¬x¥„\n\0%\Í\'\îúM<”‰|˜C»Œ>\àCğI›¡m\ZH¶€m™¾~|WT\"a‚<o€\àCõ-\áa<n\Çıû¾Í¿,õ¿ÁKúŠ÷°	ŒV°&\nk\Zº£(eT\0 P\Ã\ÅõO•G}”ˆ}Œ€3`¼h]ƒÁ-\É\Ö°}À¿ ,,\Ó\à„?&n5\ËÑƒ\ïşµ@\0‘Š\Z0\Í%\ÛA  ¯1°WAX“Ì…\Ş|\ã‘\n\ëeT(J\0\0(CP__¯­\Õ\Î9+Hü\"\"º\0`\ç8@D´¶£e¢÷\È\Ø\æÀAÀ\×9|\\Yı\ÚRÆ¯9ıkÁ \"\Õ`LÍŸ€,€m\06k u ¾fÅ½·\í­K¡\0(#\äü‡Ml\ãt>€óz€s\àEq!qpË‚\Í-p\Û·M·@œ`¤za[\'pÇƒ°0”,¸\ĞÁp«Y‰^Z(„Hy•\èÍ¿\rÀf0\Úh›9±-uÍµ»\Õı½B12T\0 P8\Ä\'ÿ\ç™Ü²f\Î%\Ò\Î\è,\0§csˆˆ\Û nöoô8·†´&ŒTbÀš€or¸¤À,À‹<Œ_\rpú„Âˆ”WÌ›\×\İ\0ö2°= l…Æ¶ ˆ\Í\rw\İ\Ô\ê‰\0…¢\ÈQ€B\á2—ÿ\è™ÉšmŸ¢\Ó±\Ó\0œ`&3¹mVs²A¶\Î9È¶úNô£—K\é\Ä	\×Ç‚`j\Ø,€\à›V:\ëû„\"ˆ”Wº±ùw\0\Ø\Ë@{9\Ø€öö…`\íUz\n…»¨\0@¡\È\åÿşød²ô‰\á}œ\Ø\é|:\ê¸e\×0†\np\æ\ÄG˜o\'\è™l=ÿ?-$°Œ‡ñ\Ë\ãNÿÁp\áxÕˆ\Şp´\Ğ\n\r\Í jX3Z	\Ô ­Y‹„ö)\ï|…B*\0P($\çü‡?>…1v\nY\Ö\0S9c“ˆ\ì‰\0«¡DQ0*#NQ…¡± \ì‰p=§E@ ”\áBŠ1Î‚\Ç$,¤\'\à‡vœu!L \Ø÷†\ã•û\0¤\0¤û\'\Ş%5B†’Œ¨›Àº‰¡K#\Öm“\İ²İ¯<ps— o—B¡(ÿ\Õù)Tõú-\0\0\0\0IEND®B`‚'),(2,'admin1234','Admin12345678.','15-1-00321',_binary '‰PNG\r\n\Z\n\0\0\0\rIHDR\0\0\0\0\0\0\0\0\0Ã¦$\È\0\0\0sBIT\Û\áO\à\0\0\0	pHYs\0\0›¤\0\0›¤¾\nIf\0\0\0tEXtSoftware\0www.inkscape.org›\î<\Z\0\0\0PLTEÿÿÿ\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0#·\á\0\0\0ÿtRNS\0	\n\r\Z !\"#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~€‚ƒ„…†‡ˆ‰Š‹Œ‘’“”•–—˜™š›œŸ ¡¢£¤¥¦§¨©ª«¬­®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁ\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ë\Ì\Í\Î\Ï\Ğ\Ñ\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\Û\Ü\İ\Ş\ß\à\á\â\ã\ä\å\æ\ç\è\é\ê\ë\ì\í\î\ïğñòóôõö÷øùúûüış\ë\Ù5\0\0\Z%IDAT\íÁ€u\Ş7ğ\ï\Ü÷\ÌmN¦©Æš\n™JoD\Å\Z[¶\ÚM\Ê)\ÛÆ˜NB’v¥\âi2–Y\ÏÓ›\íd\ì&OK1)F/\ÏZlb«GM#\ÙMj±˜\Æ4˜\æ<s\ß\ß7aœ™\Ãı¿®\ßÿºşŸ\à\Zañn0|\Âô9—®Xó\é·\ä\î-,­©)-Ü›»e\ãŸ®Y±t\áœ\é†¸¥C|§¹¬Ç\çfÿ%{k\ë¡hkö_f?7¤\Çešj\ŞõW\Ïüi\Å\æJ6Jå–•¯?{_·xúhú\Ó\á¯}TÈ *úxÆ£İ›Â\Í\Û~\Ğ\ä÷·¨H`\Ûû¿\Ô\ŞC¢–ƒ_\É)£\Êr^\Ü† \Ş\ëGg~GK}—9úz/û\ÅÜ–öÁ!\Ú\â\Ği·\ÅÀ°§\ë¤l?m\åÏ\Ô\Õ\Ã\Í\î»€\"¼}3Vòt”\í§ ş\ìI]=0,5x\Ş>\n´o\Ş\à(ŠE|¯”b•½7(†2\áı\ß)¡p¥DÀP \É\İóQ%™ı\ÂaU\È\Ï\ß*¦FÎ»\Ã#X.™¸\Ú\ÉMm#¼w¾_M-\Õ,\í\ë…\Ñ8­\ÒvRc»§$Àh°\Ğ~\Ëü\Ô\\`\åÀ0\rqÑ„=t„ü\Ô8õuÅ«%tŒ²™\í`\ÔG·…~:Šqu\ä\é÷	è³^\ç1rj\Û\ãQ0\Î-z\Â>:Ø\Ôg9®€·ÿ\é(g\ÖdL] ÿ\Ép§ó\ÜE—\Ø=\Ê\ãd¡\í ‹\ä>\n\ã8\ÏĞ­t™­C=0J\Ú@Úã°„Et©E	0¢\Ó+\èZ\é\Ñp·”<ºZ^J\\,1‡®—“·j•I\ã™­\àF\Şq¥4~T:\Î\×é´F­u\à.\áÓªiœ zZ8\\$i3SlN‚[\Ä\Î\n\Ğ8M`V,\\¡ÿ\Zg´§?œ/>‹\ÆYe\Å\Ã\á\îú\Æ9ô…“Ed\Ğ8™‘p¬›hœ\×7\×Ã™B~SI£*Ÿ\n]²’F­ºÓ·€F\í\0g‰˜I£^fGÁA\ÚüƒF=}}%\ã\ÎB\ZõV|7œÁ“ \Ñ\0©8À…\Ëh4ĞŠ‹ ½N\Ûh4\Øöë¡¹\ä2\ZP>:óÍ \ÑH>h«ùZ\Z¶¶94uõv\ZA°ıjh\é\ÖB\ZAQx+4”\\E#Hª’¡I4‚hô\â›K#¨\æú ‘\Ø\Õ4‚lu,´‘°‰F\ĞmJ€&º\ä\ÓP ¿´Ğ½ˆ†E‰\Ğ@\Ï\ZŠ”ô‚x¿,§¡LE7 Š†BU÷B´!54”ªI`øi(±\ÆÒ°Àx5†%\Ò \Ò\Z™\ÆR\'ş\â]\ß|¾\êı·22\Şz\Õ\ç\ß\ì*öS\'\ã!\Î#\ÔÄ®fŒ¹½µ§ğ´¾}ÌŒvQA˜!~Ê·wşÃ£pNQ¿—òR Ê€\Z\nw kô5¨£kFg p5÷B_VQ´\Í\Ïuö ^<Ÿ\ÛLÑªú@Œ\ålÿŒnhn3öS°Š^¢{	Åª\Ì\ê\çCƒùúeUR¬’DˆĞ¥ˆR}ÿ\ìEh¤‹ıRu\0	ùj÷“‘‚\È\'vQ¨ü\Ø.ve\Ú>¢	‚\Ä÷È¿)Ó¦X\ØÌ·š\"mŠ òù–\"­öÁ^s)Q\ÙD‚,\ì\éRJ4¶šD‰–´†­S¢I°Q2\Ú\ŞŠô\ÙF’a›[«(N\å”(1¥’\âT\İ\n›\\]Hqşu”º\î[ŠSx5l\Ñ|;Å™\rÅ¢ß¢8Û›\Ã¾µ”¦|8,ğP¥Y\ëƒõfPš]K\\»‰\ÒdÀrÉ”f~4,ùgJ“‹u*£0\Ï\ÃB\ÏP˜òÎ°Ô…\Û(K\ÍpX\ê\ZÊ²\ãbXÈ³Œ²”\ß‹õ)£,+<°N\Ze9\Ğ–\ë~€²¤\Ã2w(\Ê\Î°Á5;)J\àX¤M!E\Ù\Ñ¶h¹ƒ¢·‡%\"şAQ\n\Ú\Ã&\í(Ê¦hXa&E)¹	¶¹©„¢¼	ô¥(UwÀFwTQ”AP\î’J[\r	P’- X\ÈJŠò[\Ø\ì·\åC\Ôú\rEy¶{…¢Œ‡R+)I¶ó}NIª:C¡ˆM”¤\è\nĞº’|	u2(\Ê@ˆpEù#”¹‹¢Ì€/Q”¾P$ş{J²¾	„ğ}NI\n\â¡F%9\Øb´.¤$YP¢?EA†S”şP v%ù\ÒA<Ù”dO,‚o%	ü¢töS’Yº¤\0%yÂ¼FII²ğÍ”d„‰\İKI6‡#¸¦Q”G \ÎPŠ2\rAÕ©š’|yşNIª;!ˆ¼\ë(J/”HQ\Öy<\ã(Ê§i5E‡ iUJQú@¤\Ş¥´‚%“¢l€P\Ù%A’HY\î…P})K\"‚\"$‡¢|\ëP!ÿ¤(9!†Ê’±~EYR\Ñy%/byr)J^4\Z/²¼Á¦R–t4ZBe\éÁ®¢,	h¬E”\åŸ\ísÊ²”Da‚hS˜$4Šgeñ_\n\Ñ\âª(\Ë\Zc(…Y	\á–P˜¡h„Ğ­f„Ha¶†¢\á¢051.¢’\Â<„ó\í 0ŸA¼5f‡\r5’Ò¤C¼TJ3\r\Ôd¥\é\rñzPš]M\Ğ0c(ME\Ä+¡4c\Ğ ‘y”f54ğWJ“‰†Gqƒ¢8\ã\Ğ\0\Ñ\'\Z\èBq\n¢Q(N\ZğTPœ	¨·\È}g´ğ\Å\Ù‰ú\ZEyşZXHyF¡<[(Ï‹\Ğ\ÂTÊ³Åƒú\éO†C\É¨?\êg-ºZ\èJÖ¢^ºS¢xh!–uG}dQ bh\"Ÿe¡\Úú)\Ğ:h\â\n\äo‹ºË Dƒ&–R¢\ÔY\\%Ê‚&\æS¢²8\ÔU*EšMü‰\"¥¢\Âò)\Òh\âEŠ”†ºH™¦A“(\Ó@\Ô\ÍJ\Ê4šø-eZ‰:IP¦1\Ğ\Äp\ÊH@]L¡P@÷Q¨)¨\ïn\n5šH¡v{q~})\Õh\"…Rõ\Åù-¥TOASª¥8¯5”j241RÕ´Àù¤R¬?@¿§X©8O.\Åzšxb\åzpnwP®\Ğ\Ä\Êu\Îm>\åZMdQ®ù8§ˆC”\ëch\âo”\ëP\Îe\0\ÛM|KÁ\à\\Ş¥`h!´Š‚½‹sˆ*¥d\×AWR²\Ò(œ\İ`Š6Z¸‹¢\r\Æ\ÙeQ´ÿ€\ÆQ´,œU\ÓrŠö´0‹¢•7\Å\Ù\ÜO\Ù>‡>¢l÷\ãl–P¶bh!Ÿ²-ÁY\\PI\á.‡šS¸\Êpf\Ã(]\n4ğ+J7g¶ˆ\ÒÍ…^§t‹pF¡Å”n4°•\Ò‡\âLn¦|WB¼V”\ïfœI:\åñR(_:\Îd=\å{\âÍ¥|\ëqñ\Ê÷}¤\ÛEùñ8\İ0\ê „\ë@\Ã\é2©ƒ\é.:\È\Äi<û©ƒ½^ˆòu°ßƒSu£~\Ñn¥º\áTi\ÔC&D{“zHÃ©²©‡²yz\È\Æ)bü\ÔÄƒ\ì\×Ô„?\'»ºX\rÁşJ]Ü“M¦.WA¬+j¨‹\É8Ù‡\Ô\Æˆõ\'j\ãCœ$´”Ú¨N€P—UR¥¡8Ñ\Ô\ÈLõj\äFœh,5Rq)DjVJŒÅ‰R\'\Ó!R:u²\'Ê£NJ\â Pl1u’‡´¡^~§^\Ú\à¸dê¥¢Ä¹¼”zI\Æq¯S3+ \Îÿ£f^\Çq_Q7ƒ \Ì]\Ô\ÍW¨å«¦nv5…(‘Û©›j\éHı¼Q¦R?q\ÌP\ê§ú:rU%õ3Ç¼@\r­õBŒ\Õ\Ô\Ğ8f9u”1&RG\Ëq\Ì\ê\È\ßBü¬†:Úƒ£â¨§¼Ÿ@„¸]\ÔS\èIM­\0!Ë¨©8\â	\ê\êYğ4uõ˜M]U\'\Âvİ«©«\Ù8\"‡\Ú\Ú\Ó\Z6k½‡\Ú\ÊÁ<e\Ô\×\æf°U³\Í\ÔW™‡µ¦\Î\Ö5…š®£\ÎZ\ã°$j\íl\ãû€ZK\ÂaPo<°‰gõö\0K£\æfÀ&3¨¹46—º{96y‰º›‹\Ã>¢ö2\Ã`¹°y\Ô\ŞG8l\'õ·2\Z‹ZNı\í\Ä|~:@N3X\ê\âl:€\ß \ras,\Ô\ê:B\0½\éy7\Â2v\Òzx˜Qù8,2²‚ñ0€©tŒEÀ1\èSÌ£sl»\Êu\ŞJ\ç˜`¤òq(6º’²\nÀ:\Ê\âK¡Ğ¥‹\é(\0ì¤³|2Šx\Ç¤³\ìPF§ùG\"”ø\é:MA\ç	¼\ÙAwñ¬\0\'-\èDF…!¨B\ÙG\'jt¦\Ü\Ç\Â4MFn§3uDO:UŞ¸hE\ÔoöĞ©zbk\ßs±h´\Øÿ\ØG\ç\Z„t²\â\×nB£\ÜôZ1l&\Òá¾x9\Z\èò‰\ß\Ò\á&b:/°\æÁ\Ô[Ìƒkt¼\é˜C7(_ù\ÌM^Ô™÷¦gV–\Ó\r\æ`!İ¢x\É\Ø\ëBp^!×]RL·Xˆ¥t“‚•¯\î\İ2gÒ²÷\èWW\ĞM–bİ§ô\Ëw~ÿ\ì\èaıŞ­C«Vºı¼ÿ°\Ñ\Ïşş/K\é>+°††‹­Á§4\\\ìS|A\ÃÅ¾ÀF\Z.¶[h¸\Ø\ä\Òp±\\\ì¥\áb{QH\Ã\Å\nQJ\Ã\ÅJQC\Ã\ÅjPC\Ã\ÅjPJ\Ã\ÅJQH\Ã\Å\n±—†‹\íE.\r\Ë\Å\Z.¶i¸\ØF|A\ÃÅ¾À§4\\\ìS¬¡\ábk°‚†‹­ÀR\Z.¶i¸\ØBÌ¡\ábs0†‹M\ÇD\Z.6#h¸\Ø¢\ábƒĞ“†‹õDG\Z.\Ö-h¸XD\Ğp± Œ†k•\ØIÃµv\Ø@Ãµ6\0XEÃµV˜GÃµ\æ˜JÃµ¦x˜†k= 7\r\×\ê\r \r\r\×jÀ\ç§\æJ7¼ûò”§G%÷\ëİµ\ÃU\Êu\èÚ»\ß\ĞQOOy\é/K¨9¿?\ØIm\íø\ëK£zµMBZô\ZùÒ²\Ô\ÖNöµ´\ã\Í\ä–¡\å\Ğÿ\ŞN-}„\Ã\æR;»\ß~\è\nˆ\Òú¹;©¹8,zÙŸ\Ñ\"u}µ€zI\ÃaP#\ïöA¬°>Ê©‘pXµññ#±.\æÁ5\ÔFkM=–t…nX Z\ã0O5P“ù ój¨2~”Cñª\Şh­´UEñrp\Äl\n˜\İ\Úi9;@\áf\ãˆ\'(Ûº®\ĞR·õ”\í	Ñ“’\íá¦<R²8\"rf\ÅAc\Í\ŞP®8µ‡Rm¸	šë¾‘R\íÁ1\Ë)TFh/\â\r\nµÇ¼@‘Š\Â~}ˆ\"½€c†R¢œ+\à\í¾¤DCqLG\nô’\Ñd\êˆc|Õ”\æ\Ğ\İp”A¥”¦Ú‡Z_Q˜ü\à0?\İOa¾\Âq¯S–·…\ã\\•KY^\Çq\Ée}s8\Ğe_Q”d×†’¬j\nGŠıˆ’´Á	ò(\Ç;>8TøbÊ‘‡-¤™8–7‹b,Ä‰\ÆRŠ\åap°&RŠ±8Ñ\â³(8Z\Ì\âFœ(´”\"|}\î\'›)Bi(Nò!%\Èm\Çk½›|ˆ“M¦\0\í\á\× \0“q²\Ûi¿šŸÁzûi¿\Ûq²?m÷,\\b2m\çÁ)²i·e!p	\ï\Z\Ú-§J£\Ív\ÆÁ5.ı6KÃ©º\Ñ^Õ‰p‘\Û´W7œÊ³Ÿ¶\ZW™J[\í÷\à4™´Ó²¸Š÷\Ú)§F•¶‚\Ë\\SE\r\Ã\é\â´\Ï\Ópÿ¤}ñ8ƒõ´\Í\×ap¨\ïh›õ8“t\Ú\æ¸\Ğ\0\Ú&gr3\í2®´œv¹gZL{ş®Ô¶‚ö(\Å-¢=ƒKıöX„3F[|—º ˆ¶†3» ’v\r×šB;T^€³XB\ì\r‡kÅ•\ĞKp6÷\Ó\ã\áb\Óiƒûq6M\Ëi¹M\áb—V\Ğr\åMqVY´\Üópµ™´\\\În0­vğB¸ZB5­6gUJ‹½—{+\Â9¼K‹u\Ëõ¡\Å\ŞÅ¹ µ6\Â\íB¿§µ\à\\\"\ÑROÁõ^¦¥E\àœ\æ\ÓJ5—\Âõº\ĞRóqnw\ĞJ\Ëa\àkZ\éœ›\'—º¦…r=8TZ§8ZøiTœO‹\ZZfŒ|F\ËÔ´Ày-¥eFÀøA:-³\ç×—–¹\Æz\Ó2}q~\Şİ´\Èn‡ET\Ğ\"»½¨ƒ)´\È\Û0~´†™‚ºH\Ğ\ZÁøQ*­H@¬¤5®€ñ£DZc%\êf -±\Æa%´\Ä@\ÔMX>­0\ÆQ«i…ü0\ÔQ*­\nã¨™´B*\ê*®Œ\ã¨\'i²8\ÔY-\Ğ\ÆQ¿¤2PwmıT.ã¨¶T\Ï\ßõE\åvÀ8\Æ[I\å²Pİ©\Ürµ6Q¹î¨—µT\íeµŞ§jkQ?ı©\Ú(µş‹ªõGıx¶P±{a\Ô\ZOÅ¶xPO£¨\Ø/`\Ô\ZI\ÅF¡¾\"÷Q­0j\r¡Zû\"Qo¨V\'µ\î¡ZP\ÑTª\rŒZ½¨TA4\Z`•ú	ŒZ7Q©qhˆ\È<ª£\Ö\ÕT)/\r2†\n\ÕÀ8®%U\Zƒ†i²‹\ê”À8.\n\íj‚\ZI…¢`\Ô\ê@…F¢¡|;¨Î•0j\İFuvø\Ğ`Q0j=HuBÃ…n¥2\É0j¥R™­¡h„¡TfŒZ¯S™¡h\Ïª’£\Ö2ª²ÁƒFI¢*K`\Ôú\'UIB#-¢\"[a^BE¡±*¨H\'G\İCE*\Ğh\éT$\ÆQó©H:\Z/:jl…qD\Ä!ª‘ H¡\"]`üh\0IA0„\äPÿ„ñ£T#\'A‘H5¶Á8,²„j$\"H2©Fw?¸jd\"XZ•R‰ÿ\rğS‰\ÒVšqT\ãxjŒCğx\×Q‰\ï/„\ë%”S‰u^Q§j*‘\×[B%ª;!¨¦Q	ÿ\rp¹;©\Æ4Wøf*‘í«…o¥›\ÃdI*‘\nWË $\İ,ª1\Z.6…j\ÌBğ\Å\î¡d¸\ÖSTcO,\èO5júÁ¥†S‘şP\"‹jTş®ô+?\ÕÈ‚\ZñT£¤;\\¨O\Õ(ˆ‡\"}©H\é¯\á:WQ‘¾P\æT\å\å0¸J\ä<ªòG¨ù-Uù\ä¸H»¯¨Ê·‘P¨sU\Éû\\\ã\î\"ªR\ÕJ§2\Õc\á\Şô\0•µ<R\Ì(¸@\Üß¨Î‡(\Ö\â\0\Õùª\ï¦\ï¨ÎPn*¾÷h%\Z¼I…\é8Xø›T\éMX!zUZy1+a=U\Ú\rK´/¦Jyı\áL!#R¥\âö°\È=*õ^s8P\Û5T*p,“Nµö\'\Ãi¼\ãÊ¨V:¬\ãYAÅ–·‚£\\û9[á….\ŞA\Å=\Ç{¾’Š\í¸–\ê\\N\Õ>n‡¸\áŸT­¼3,–B\åÊŸ	…DüW\r•K\å2¨\ŞúN\Ğ\ŞÍ›©^¬\ç[Kõª§†Ck13To­6h¾\Øù \Úò- ¶7‡-®.¤¾¾zò$\ï \n¯†Mn­¢%ş÷g\ĞPŸ¯h‰ª[a›dZd\éµ\ĞL\âÇ´H2l4‰ñÿ¹4\Òa	­2	¶šK«T¼x14\Ñ\ê\Ï~Ze.\ì\å[M\ËMˆ„\â¦W\Ğ2«}°Y\ì&Zg\ÏcQ.\îùbZgS,l—O¾˜\0Á:ıw9-”Ÿ\0º\ÑJş%½!“w\àG´TQˆXBkm\Zq.~\æ;Z«$Bôª ÅŠ¦·(×½QF‹Uô‚}ªh5ÿ\Ò\ÛB „·ÿ\ZZ®ª¹·†\Öû\æ±hp\Ñø´^Í½%%@\Ì	[]0dq9mH0\Ñe‹~›\Ä=´¬’öxâŒ§]*ÿç‹`¹KF­ª¡]\ÆC É´Oõ\ßm]ş\ä\'\Úg2DJ£ü\Ó–h÷Lm•¡\Æ\Ó^ux	”j}\Æ×´\Ùxˆ5*@\Ûm›û\èµ!PÀ\ÛeÌ‚]´]`K©¡…\Ë&&E\"ˆbnKû „Ô¤@´{«(DUöô— Z\İ÷Ú—~\nQu/„\ëSAA\ä¼3õÁ[Z„ <—÷|d\Ú{\ë‹)HEˆ×«„\â”oZú‡Ñ¿¸Ò‡:	¿æ®±¯.ûW%\Å)\é\r$Q(ÿ³\æ\Î|\áùq#†ö»­ûumšG‡\0¦—´\í”x{ÿ\äQO¥ı\ß?¾µø\ï;ª(Z\è’O]JË¨ü.\ĞD\Â&\ZA·)Úˆ]M#\ÈV\ÇB#¾¹4‚j®z™D#ˆ&A;\ÉU4‚¤*\ZºµFP\Ş\n-]½Fl¿\Zšj¾–F£­mmùf\Ğh¤t–\\F£Ê‡As¶\Ñh°\í\×C{.£\Ñ@+.‚x\Ò4\Z 0\Õg¸³F½\ß\r\Çhó\Zõôõ•pˆ™4\êevœ¥o:\Û?\0s\ÉJ\Zu´\ê28P\Èo*i\ÔA\åS!p¦›hœ\×7\×Ã±\"2hœ\Ç\ÌH8\Ù]\ß\Ó8‡‚¾p¸ø,\Zg•\çë¿‡\Æ\í\éWˆ qšÀ¬X¸E\Òf\Z§Øœ	ŸVM\ã\Õ\Ó\Â\á.\ÖÑ¨µ®\\\Ç;®”ÆJ\Çy\áF­2iü ³\Ü*1‡®—“IÉ£«å¥„Àİ¢\Ó+\èZ\é\Ñ0Ñ¥%À8,i]hCŒ£<C·\Òe¶õÀ8.ô\á\\ºH\îÃ¡0N\æµ›.±{”\Æ\éÂŸÌ§\ä?\ãÌ¢\ŞO‡\ÛÿtŒ³‹I=@;\Z\ãÜ¢ÿ7j\Û\ãQ0\Î\Ï;ğ3:\Ğg½0\ê¨\Çb?Å¿¸Œúh7³ŒQ6³ŒúŠKÍ§#\ä§\ÆÁhˆ°+\Ô\\`\åÀ0\r–0e75¶{JŒ\Æñö]ZC-\Õ,\í\ë…-Rs©\Ü\Ô0‚\ÅsÇ¼ƒ\Ô\ÈÁywx`Ux¿\Ìj¡$³_8\",(¥p¥DÀP&r\Ğ{e«\ì½A‘0‹\Z<o\Ú7opKxºN\ÊöSö¤®Vjvÿ\Û¡\à\íû›Á°§\ë¤l?m\åÏ\Ô\Õ\Ã>1·¥}pˆ¶8ôA\Úm10\ì\ç½~t\æw´\Ôw™£¯÷\Â¤\å\àWr\Êh²œW·„!‘·ı ß½¿-@E\Û\Şÿİ ö^²5\íşèŒ‹TE\Ïx´{Súˆ\ïvß³¯¯\ÜR\ÉF©Ü²òõg\ï\ëCS\Ëzynö_²·±Š¶fÿeösCz\\\æ\áañn0|\Âô9—®Xó\é·\ä\î-,­©)-Ü›»e\ãŸ®Y±t\áœ\é†¸¥C|\\\ãÿŠ\\æ˜‘PIš\0\0\0\0IEND®B`‚');
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
INSERT INTO `event` VALUES (2,'General Cleaning - May','2024-05-05 00:00:00','2024-08-17 13:00:00','Mabolo','Monthly Cleaning',_binary '',100,0),(3,'rgtr','2024-08-19 00:00:00','2024-08-17 17:26:00','fghfghfgh','dfgfg',_binary '',100,0),(4,'ertre','2024-08-20 00:00:00','2024-08-17 21:00:00','rtyyrt','ertyrt',_binary '',100,0);
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
INSERT INTO `event_attendance` VALUES (8,'Absent','10-1-00231',2),(30,'Present','22-1-00223',2),(34,'Present','22-1-00232',2),(43,'Absent','22-1-00235',2),(44,'Absent','10-1-00231',3),(45,'Absent','15-1-00321',3),(46,'Present','22-1-00223',3),(47,'Present','22-1-00232',3),(48,'Present','22-1-00235',3),(49,'Present','23-1-02140',2),(50,'Present','23-1-02140',3),(51,'Absent','10-1-00231',4),(52,'Absent','15-1-00321',4),(53,'Absent','22-1-00223',4),(54,'Absent','22-1-00232',4),(55,'Absent','22-1-00235',4),(56,'Absent','23-1-02140',4);
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
INSERT INTO `payment` VALUES (1,'2024-08-17 21:00:40',4150,'All','22-1-00232');
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
INSERT INTO `room` VALUES (1,1,6,0),(2,1,6,0),(3,1,6,0),(4,2,12,4),(5,2,6,0),(6,2,6,0),(7,3,6,0),(8,3,6,0),(9,3,6,0);
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
INSERT INTO `room_allocation` VALUES (1,'2024-08-17','2024-09-17',4,'22-1-00223'),(2,'2024-08-17','2024-09-17',4,'22-1-00232'),(3,'2024-08-17','2024-09-17',4,'22-1-00235'),(4,'2024-08-17','2024-09-17',4,'23-1-02140');
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
INSERT INTO `user` VALUES ('10-1-00231','Rhuel','Laurente','1993-07-31','johnrhuell@gmail.com','+639099153674','Brgy. Combis, Dulag, Leyte','Active','Dormitory Adviser',28,0,0,0),('15-1-00321','Darius','Mendoza','2024-04-12','darius@gmail.com','+639099163732','Brgy. Dar, Baybay City, Leyte','Active','Assistant Dormitory Adviser',14,0,0,0),('22-1-00223','Test','Subject','2024-08-15','joe@gmail.com','+639099153546','Somewhere','Active','Big Brod',26,1,1,1),('22-1-00232','James','Del Cruze','2024-08-10','rerer@gmail.com','+639099153546','Mabolo','Active','Big Brod',5,1,1,1),('22-1-00235','Joeer','erer','2024-08-10','john@gmail.com','+639099266323','ererr','Active','Big Brod',20,1,1,1),('22-1-00323','jdfdf','sdf','2024-08-10','dfj@gmail.com','+639099153546','erewrer','Active','Regular Dormer',23,0,0,0),('23-1-02140','DM','Varques','2004-12-01','sjhdhjsf@gmail.com','+639099153546','Korea','Active','Big Brod',28,1,1,0);
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
INSERT INTO `user_payable` VALUES (1,3650,3650,'22-1-00223'),(2,4250,100,'22-1-00232'),(3,4350,4350,'22-1-00235'),(4,3200,3200,'23-1-02140'),(5,1650,1650,'22-1-00323');
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

-- Dump completed on 2024-08-17 21:28:21
