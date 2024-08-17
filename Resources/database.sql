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
INSERT INTO `account` VALUES (1,'admin132','Admin12345678@','10-1-00231',_binary '�PNG\r\n\Z\n\0\0\0\rIHDR\0\0\0\0\0\0\0\0\0æ$\�\0\0\0sBIT\�\�O\�\0\0\0	pHYs\0\0��\0\0���\nIf\0\0\0tEXtSoftware\0www.inkscape.org�\�<\Z\0\0\0PLTE���\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0#�\�\0\0\0�tRNS\0	\n\r\Z !\"#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~������������������������������������������������������������������\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\����������������\�\�5\0\0\Z%IDAT\����u\�7�\�\��\�mN��ƚ\n��JoD\�\Z[�\�M\�)\�ƘNB�v�\�i2�Y\�ӛ\�d\�&OK1)F/\�Zlb�GM#\�Mj��\�4�\�<s\�\�7a��\����\�����\�\Za�n0|\��9��X�\��\�\�-,��)-ܛ�e\���Y�t\�\����C|���ǐ\�f�%{k\�hk�_f?7�\�e�j\��W\��i\�\�J6J喕�?{_�x�h�\�\�}TȠ*�xƣݛ\�\�~\�\����H`\���\�\�C���_\�)�\�r^\�� \�\�Gg~GK}�9�z/�\�ܖ��!\�\�\�i�\�����\�l?m\�Ϟ\�\�\�\�\���\"�}3V�t��\� �\�I]=0,5x\�>\n�o\�\�(�E|��b��7(�2\��\�)�p�D�P�\�\��Q%��\�aU\�\�\�*�Fλ\�#X.���\�\�Mm#�w�_M-\�,\�\�\�8�\�vRc��$�h�\�~\��\�\\`\��0\rqф=t��\�8�uū%t���\�`\�G��~:�qu\�\��	賁^\�1rj\�\�Q0\�-z\�>:؁\�g9����\�(g\�dL] �\�p��\�E�\�=\�\�d�\�\�>\n\�8\�Эt��C=0�J\�@ڐ㰄Et�E	0�\�+\�Z\�\�p���<�Z^J\\,1�����j�I\���\�F\�q�4~T:\�\�鴎F�u�\�.\�Ӫi��zZ8\\$i3�SlN�[\�\�\n\�8M`V,\\��\Zg��?�/>�\�Ye\�\�\�\���\�9�Ed\�8���p���h�\�7\�ÙB~SI�*�\n�]��F���ӷ�F�\�\0g��I�^fG�A\���F=}}%\�\�B\Z�V|7����\�\0��8��\�h4Њ���N\�h4\��롹\�2\Z�P>:�͠\�H>h��Z\Z���94u�v\ZA��jh\�\�B\ZAQx+4�\\E#H����I4�h�\�K#�\����\�\�4�lu,����F\�mJ�&�\�\�P ��н��E�\�@\�\Z���x�,��LE7���BU�B�!54��I�`��i(�\�Ұ�x5��%\� \�\Z��\�R\'�\�]\�|�\���22\�z\�\�\�\�*�S\'\�!\�#\�Įf������}̌vQ�A�!~ʷw�Ý�pNQ�����R ʀ\Z\nw k�5��kFg�p5�B�_VQ�\�\�u��^<��\�LѪ�@��\�l��nh�n3�S��^�{	Ū\�\�\�C���eUR��D�Х�R}�\�Eh�����Ru�\0	�j����\�\'vQ��\�.ve\�>�	�\��ȿ)ӦX\�̷�\"m� ���\"���^s)Q\�D�,\�\�RJ4��D�����S�I�Q2\�\���\�F��a�[�(N\�(1��\�T\�\n�\\]Hq�u��\�[�Sx5l\�|;ř\rŢߢ8ۛ\�����|8,�P�Y\��fP�]K\\��\�d�rɔf~4,�gJ��u*�0\�\�B\�P��ΰԅ\�(K\�pX\�\Zʲ\�bXȳ���\���)�,+<�N\Ze9\��\�~���\�2w(\�\���5;)J\�X�M!E\�\��h�����%\"�AQ\n\�\�&\�(ʦhXa&E)�	������	��(Uw�FwTQ�AP\�J[\r	P�-�X\�J��[\�\�\�C\��\rEy�{����R+)I���}NI�:C��M��\�\nк��|	u2(\�@�pE�#����̀/Q��P$�{J��	��}NI\n\�F%9\�b�.�$YP�?EA�S��P v%�\�A<ٔdO,�o%	��t�S�Y��\0%y¼FII��͔d��\�KI6�#��Q�G \�P�2\rAթ��|y�NI�;!��\�(J/�HQ\�y<\�(ʧi5E��iUJQ�@�\����%��l�P\�%A�HY\�P})K\"�\"$��|\�P!��(9!�ʒ�~EYR\�y%/byr)J^4\Z/�����R�t4ZBe\����,	h�E�\�\�sʲ��Da��h�S�$4�ge�_\n\�\�(\�\Zc(�Y	\�P��h�Эf�Ha���\��051.��\�<��\�0�A�5f�\r5�ҤC�TJ3\r\�d�\�\r�zP�]M\�0c(ME\�+�4c\� �y�f54�WJ���Gq����8\�\�\0\�\'\Z\�Bq\n�Q(N�\Z�TP�	��\�}g��\�\���\ZEy�ZXHyF��<[(ϋ\�\�TʳŃ�\�O��C\��?\�g-�Z\�J�֢^�S�xh!�uG}dQ�bh\"�e�\��)\�:h\�\n\�o��ˠD�&�R�\�Y\\%ʂ&\�S��8\�U*E�M��\"���\��)\�h\�E����H��A�(\�@\�\�J\�4��-eZ�:IP�1\�\�p\�H@]L�P@�Q�)�\�n\n5�H�v{q~})\�h\"�R�\��-�TOA�S��8�5�j241�Rմ���R�?@��X�8O.\�z�x�b\�zpnwP�\�\�\�u\�m>\�ZMdQ��8��C�\�ch\�o�\�P\�e\0\�M|K�\�\\ޥ`�h!�����s�*�d\�AWR�\�(�\�`�6Z���\r\�\�eQ���\�Q�,�U\�r���0���7\�\�\�O\�>�>�l�\�l�P�bh!��-�Y\\PI\�.��S�\�pf\�(]\n4�+J7g��\�ͅ^�t�pF�Ŕn4��\��\�Ln�|WB�V�\�f�I:\��R(_:\�d=\�{\�ͥ|\�q�\��}�\�E��8\�0\��\�@\�\�2��\�.�:\�\�i<����^��u�߃Su�~\�n��\�Ti\�C&D{�zHé����y�z\�\�)b�\�ă\�\�Ԅ?\'���X\r��J]܎�M�.WA�+j��\�8ه\�\���\'j\�C�$��ڨN�P�UR��8э\�\�L�j\�F�h,5Rq)DjVJ��ŉR\'\�!R:u�\'ʣNJ\� Pl1u����^~���^\�\�dꥢĹ��zI\�q�S3+ \���f^\�q_Q7� \�]\�\�W�嫦nv5�(�۩�j�\�H��Q�R?q\�P\��:rU%�3Ǽ@\r��B��\�\�\�8f9u�1&RG\�q\�\�\�\�B���:ڃ�⨧��@��]\�S�\�IM��\0!˨��8\�	\�\�Y�4u���M]U\'\�vݫ��\�8\"�\�\�\�\Z6k��\�\���<e\�\�\�f�U�\�\�W����\�\�5�����\�Z\�$j\�l\���ZK\�aPo<��g��\0K�\�f�&3��46��{96y����\�>��2\�`��y\�\�G8l\'��2\Z�ZN�\�\�|~:@N3X\�\�l:�\��\ras,\�\�:B\0�\�y7\�2�v\�zx�Q�8,2���0��t�E�1\�S̣sl�\�u\�J\�`��q(6���\n�:\�\�K�Х�\�(\0줳|2�x\���\�PF��G\"��\�:MA\�	�\�Aw�\0�\'-\�DF�!�B\�G\'j��t�\�\�\�4MFn�3uDO:U޸hE\�o�Щzb�k\�s�h�\��\�G\�\Z�t�\�\�nB�\��Z1�l&\�ᾝx9\Z\��\�\�\�&b:/�\��\�[̃kt�\�C7(_�\�M^ԙ��gV�\�\r\�`!ݢx\�\�\�Bp^!׍]RL�X��t�����\�\�2gҲ�\�WW\�M�bݧ�\�w~�\�\�a�ޭC�V�����\�\����/K\�>+�������4\\\�S|A\�ž�F\Z.�[h�\�\�\�p�\\\�\�b{QH\�\�\nQJ\�\�JQC\�\�jPC\�\�jPJ\�\�JQH\�\�\n����\�E.\r\�\�\Z.�i�\�F|A\�ž��4\\\�S��\�bk������R\Z.�i�\�B̡\�bs0���M\�D\Z.6#h�\��\�b�Г���DG\Z.\�-h�XD\�p����k�\�Iõv\�@õ6\0XEõV�Gõ\��Jõ�x��k=�7\r\�\�\r�\r\r\�j�\�\�J7���G%�\�ݵ\�U\�u\�ڻ\�\�QOOy\�/K�9�?\�Im\��\�K�z��MBZ�\Z�Ҳ\�\�N���\�\�\��\�\��\�N-}�\�\�R;�\�~\�\n�\����;���8,�zٟ\�\"u}��zI\�aP#\��A��>ʩ�pX���#�.\��5\�FkM=�t�nX�Z\�0O5P�����j��2~�C�\�h���UE�rp\�l\n�\�\�i9;@\�f\�\'(ۺ�\�R���\�	ѓ�\�ၦ<�R��8\"�rf\�Ac\�\�P�8��Rm�	�뾑R\��1\�)TFh/\�\r\n�Ǽ@��\�~}�\"��c�R��+\�\�DCqLG\n���\�d\�c|Ք\�\�\�p�A���ڇZ_Q��\�0?\�Oa�\�q�S���\�\\�KY^\�q\�e}s8\�e_Q�d׆��j\nG������	�(\�;>8T�bʑ�-��8�7�b,ĉ\�R�\�ap�&R��8э\�(8Z\�\�F�(��\"|}\�\'�)Bi(N�!%\�m\�k��|��M�\0\�\�\��\0�q�\�i����z�i�\�q�?m�,\\b2m\��)�i�e!p	\�\Z\�-�J�\�v\��5.��6Ké�\�^Չp�\��W7�ʳ��\ZW�J[\��\�4��Ӳ���\�)�F���\�\\SE\r\�\�\��\�\�p���}�8���\�\�ap��\�h��8�t\�\��\�\0\�&gr3\�2���v�gZL{��Զ��(\�-�=�K���X�3F[|������3���v\rךB;T^��XB\�\r�kŕ\�Kp6�\�\�\�b\�i��q6M\�i�M\�b�V\�r\�MqVY�\��p���\\\�n0�v�B�ZB5�6gUJ���{�+�\�9�K�u�\���\�\�Ź��6\�\�B���\�\\\"\�RO��^��E\��\�\�J5�\���\�R�qnw\�J\�a\�kZ\���\'�����r=8�TZ�8Z�i�T�O�\ZZf�|F\�Դ�y-�eF��A:-�\�ח��\�z\�2}q~\�ݴ\�n�ET\�\"����)�\�\�0~�����H\�\Z��Q*�H@���5���DZc%\�f -�\�a%�\�@\�MX>�0\�Q�i��0\�Q*��\n㨙�B*\�*��\�\'i��8\�Y-\�\�Q��2Pwm�T.㨶T\�\���E\�v�8\�[I\�Pݩ\�r�6Q��T\�e�ާjkQ?��\�(�����G�x�P�{a\�\ZOŶxPO��\�/`\�\ZI\�F��\"�Q�0j\r�Z�\"Qo�V\'�\�ZP\�T�\r�Z��TA4\Z`��	�Z7Q�qh�\�<��\�\�T)/\r2�\n\��8�%U\Z��i��\��8.�\n\�j�\ZI��`\�\�@�F��|;�Ε0j\�Fuv�\�`Q��0j=HuBÅn�2\�0j�R���h��Tf�Z�S��h\����\�2����FI�*K`\��\'UIB#-�\"[a^BE��*�H\'G\�CE*\�h\�T$\�Q�H:\Z/:�jl�qD\�!��� H�\"]`�h\0IA0�\�P����T#\'A�H5��8,��j$\"H2�Fw?��jd\"XZ�R��\r���S�\�V�qT\�x�j�C�x\�Q�\�/�\�%�S�u^Q�j*�\�[B%�;!��Q	�\rp�;�\�4W�f*�큫�o��\�dI*�\nWˠ�$\�,�1\Z.6�j\�B�\�\��d�\�STcO,\�O5j����S��P\"�jT���+?\�Ȃ\Z�T��;\\�O\�(��\"}�H\�\�:�WQ��P\�T\�\�0�J\�<��G��-U�\��H���ʷ�P�sU\��\\\�\�\"�R\�J��2\�c\�\��\0��<R�\�(�@\�ߨ·(\�\�\0\���\�\�΁Pn*��h%\Z�I�\�8X��T\�MX!zUZy1+a=U\�\rK�/�Jy�\�L!#R�\���\�=*�^s8P\�5T*p,�N��\'\�i�\�ʨV:�\�YAŖ���\\�9[၅.\�A\�=\�{���\��\�\\N\�>n��\�T��3,�B\�ʟ	�D�W\r�K�\�2�\��N\�\�͛�^�\�[K����Ck13To�6h��\���\��-��7�-�.���z�$\�\n��Mn��%��g\�P��h��[a�dZd\�\�L\�ǴH2l4����4\�a	�2	��K�T�x14\�\�\�~Ze.\�\�[M\�M��\�W\�2�}�Y\�&Zg\�cQ.\��bZgS,l��O��\0�:�w9-��\0�\�J�%�!�w\�G�TQ��XBkm\Zq.~\�;Z�$B���Ŋ���(׽QF�U�}�h5�\�\�B ���\ZZ�����\��\�hp\���^ͽ%%@\�	[]0dq9mH�0�\�e�~�\�=����x⌧]*�灋`�KF���]\�C�ɴO�\�m]�\�\'\�g2DJ���\��h�Lm��\�\�^�ux	�j}\�״\�x�5*@\�m��\�!P�\�ê]�]`K���\�&&E\"�bnK���Ԥ@�{�(DU��� Z\��ڗ~\nQu/�\�SAA\�3��[Z��<��|d\�{\�)HE�׫�\�oZ��ѿ�҇:	�殱�.�W%\�)\�\r$Q(���\�\�|\��q#�����um�G�\0����\�x{�\�QO��\�?���\�;�(Z\�O]J˨��.\�D\�&\ZA�)ڈ]M#\�V\�B#��4�j�z�D#�&A;\�U4��*\Z���FP\�\n-]��Fl�\Z�j��F��mm�f\�h�t�\\F�ʇAs��\�h�\�\�C{.�\�@+.�x\�4\Z 0\�g���F�\�\r\�h�\Z����p���4\�ev��o�:\�?\0�s\�J\Zu�\�28P\�o*i\�A\�S!p���h�\�7\�ñ\"2h�\�\�H8\�]\�\�8���p��,\Zg�\�뿇\�\�\�W���q���X�E\�f\Z�؜	�VM\�\�\�\�\�.�\�Ѩ��\\\�;��ƏJ\�y\�F�2i� �\�*1����Iɣ�奄�ݢ\�+\�Z\�\�0ѥ%�8,i]hC��<C�\�e���8.�\�\\�H\�á0N\���.�{�\�\�̧\�?\�̢�\�O�\��t���I=@;�\Z\�ܢ�7j\�\�Q0\�\�;�3:\�g�0\�\�b?ſ���h7���Q6����Kͧ#\�\��h���+\�\\`\��0\r�0e75�{J�\���]ZC-\�,\�\�-Rs��\�\�0�\�sǼ�\�\��ywx`Ux�\�j�$�_8\",(�p�D�P&r\�{e�\�A�0�\Z<o\�7opKx�N\��S���Vjv�\��\�\�������\�l?m\�Ϟ\�\�\�>1��}p��8�A\�m10\�\�~t\�w�\�w����\��\�\�Wr\�h���W��!����߽�-@E\�\��ݠ�^�5\��茏�TE\�x�{S��\�v߳��\�R\�F�ܲ��g\�\�CS�\�zyn�_�����f�e�sCz\\\�\�a�n0|\��9��X�\��\�\�-,��)-ܛ�e\���Y�t\�\����C|\\\���\\昑PI�\0\0\0\0IEND�B`�'),(2,'admin1234','Admin12345678.','15-1-00321',_binary '�PNG\r\n\Z\n\0\0\0\rIHDR\0\0\0\0\0\0\0\0\0æ$\�\0\0\0sBIT\�\�O\�\0\0\0	pHYs\0\0��\0\0���\nIf\0\0\0tEXtSoftware\0www.inkscape.org�\�<\Z\0\0\0PLTE���\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0#�\�\0\0\0�tRNS\0	\n\r\Z !\"#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~������������������������������������������������������������������\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\�\����������������\�\�5\0\0\Z%IDAT\����u\�7�\�\��\�mN��ƚ\n��JoD\�\Z[�\�M\�)\�ƘNB�v�\�i2�Y\�ӛ\�d\�&OK1)F/\�Zlb�GM#\�Mj��\�4�\�<s\�\�7a��\����\�����\�\Za�n0|\��9��X�\��\�\�-,��)-ܛ�e\���Y�t\�\����C|���ǐ\�f�%{k\�hk�_f?7�\�e�j\��W\��i\�\�J6J喕�?{_�x�h�\�\�}TȠ*�xƣݛ\�\�~\�\����H`\���\�\�C���_\�)�\�r^\�� \�\�Gg~GK}�9�z/�\�ܖ��!\�\�\�i�\�����\�l?m\�Ϟ\�\�\�\�\���\"�}3V�t��\� �\�I]=0,5x\�>\n�o\�\�(�E|��b��7(�2\��\�)�p�D�P�\�\��Q%��\�aU\�\�\�*�Fλ\�#X.���\�\�Mm#�w�_M-\�,\�\�\�8�\�vRc��$�h�\�~\��\�\\`\��0\rqф=t��\�8�uū%t���\�`\�G��~:�qu\�\��	賁^\�1rj\�\�Q0\�-z\�>:؁\�g9����\�(g\�dL] �\�p��\�E�\�=\�\�d�\�\�>\n\�8\�Эt��C=0�J\�@ڐ㰄Et�E	0�\�+\�Z\�\�p���<�Z^J\\,1�����j�I\���\�F\�q�4~T:\�\�鴎F�u�\�.\�Ӫi��zZ8\\$i3�SlN�[\�\�\n\�8M`V,\\��\Zg��?�/>�\�Ye\�\�\�\���\�9�Ed\�8���p���h�\�7\�ÙB~SI�*�\n�]��F���ӷ�F�\�\0g��I�^fG�A\���F=}}%\�\�B\Z�V|7����\�\0��8��\�h4Њ���N\�h4\��롹\�2\Z�P>:�͠\�H>h��Z\Z���94u�v\ZA��jh\�\�B\ZAQx+4�\\E#H����I4�h�\�K#�\����\�\�4�lu,����F\�mJ�&�\�\�P ��н��E�\�@\�\Z���x�,��LE7���BU�B�!54��I�`��i(�\�Ұ�x5��%\� \�\Z��\�R\'�\�]\�|�\���22\�z\�\�\�\�*�S\'\�!\�#\�Įf������}̌vQ�A�!~ʷw�Ý�pNQ�����R ʀ\Z\nw k�5��kFg�p5�B�_VQ�\�\�u��^<��\�LѪ�@��\�l��nh�n3�S��^�{	Ū\�\�\�C���eUR��D�Х�R}�\�Eh�����Ru�\0	�j����\�\'vQ��\�.ve\�>�	�\��ȿ)ӦX\�̷�\"m� ���\"���^s)Q\�D�,\�\�RJ4��D�����S�I�Q2\�\���\�F��a�[�(N\�(1��\�T\�\n�\\]Hq�u��\�[�Sx5l\�|;ř\rŢߢ8ۛ\�����|8,�P�Y\��fP�]K\\��\�d�rɔf~4,�gJ��u*�0\�\�B\�P��ΰԅ\�(K\�pX\�\Zʲ\�bXȳ���\���)�,+<�N\Ze9\��\�~���\�2w(\�\���5;)J\�X�M!E\�\��h�����%\"�AQ\n\�\�&\�(ʦhXa&E)�	������	��(Uw�FwTQ�AP\�J[\r	P�-�X\�J��[\�\�\�C\��\rEy�{����R+)I���}NI�:C��M��\�\nк��|	u2(\�@�pE�#����̀/Q��P$�{J��	��}NI\n\�F%9\�b�.�$YP�?EA�S��P v%�\�A<ٔdO,�o%	��t�S�Y��\0%y¼FII��͔d��\�KI6�#��Q�G \�P�2\rAթ��|y�NI�;!��\�(J/�HQ\�y<\�(ʧi5E��iUJQ�@�\����%��l�P\�%A�HY\�P})K\"�\"$��|\�P!��(9!�ʒ�~EYR\�y%/byr)J^4\Z/�����R�t4ZBe\����,	h�E�\�\�sʲ��Da��h�S�$4�ge�_\n\�\�(\�\Zc(�Y	\�P��h�Эf�Ha���\��051.��\�<��\�0�A�5f�\r5�ҤC�TJ3\r\�d�\�\r�zP�]M\�0c(ME\�+�4c\� �y�f54�WJ���Gq����8\�\�\0\�\'\Z\�Bq\n�Q(N�\Z�TP�	��\�}g��\�\���\ZEy�ZXHyF��<[(ϋ\�\�TʳŃ�\�O��C\��?\�g-�Z\�J�֢^�S�xh!�uG}dQ�bh\"�e�\��)\�:h\�\n\�o��ˠD�&�R�\�Y\\%ʂ&\�S��8\�U*E�M��\"���\��)\�h\�E����H��A�(\�@\�\�J\�4��-eZ�:IP�1\�\�p\�H@]L�P@�Q�)�\�n\n5�H�v{q~})\�h\"�R�\��-�TOA�S��8�5�j241�Rմ���R�?@��X�8O.\�z�x�b\�zpnwP�\�\�\�u\�m>\�ZMdQ��8��C�\�ch\�o�\�P\�e\0\�M|K�\�\\ޥ`�h!�����s�*�d\�AWR�\�(�\�`�6Z���\r\�\�eQ���\�Q�,�U\�r���0���7\�\�\�O\�>�>�l�\�l�P�bh!��-�Y\\PI\�.��S�\�pf\�(]\n4�+J7g��\�ͅ^�t�pF�Ŕn4��\��\�Ln�|WB�V�\�f�I:\��R(_:\�d=\�{\�ͥ|\�q�\��}�\�E��8\�0\��\�@\�\�2��\�.�:\�\�i<����^��u�߃Su�~\�n��\�Ti\�C&D{�zHé����y�z\�\�)b�\�ă\�\�Ԅ?\'���X\r��J]܎�M�.WA�+j��\�8ه\�\���\'j\�C�$��ڨN�P�UR��8э\�\�L�j\�F�h,5Rq)DjVJ��ŉR\'\�!R:u�\'ʣNJ\� Pl1u����^~���^\�\�dꥢĹ��zI\�q�S3+ \���f^\�q_Q7� \�]\�\�W�嫦nv5�(�۩�j�\�H��Q�R?q\�P\��:rU%�3Ǽ@\r��B��\�\�\�8f9u�1&RG\�q\�\�\�\�B���:ڃ�⨧��@��]\�S�\�IM��\0!˨��8\�	\�\�Y�4u���M]U\'\�vݫ��\�8\"�\�\�\�\Z6k��\�\���<e\�\�\�f�U�\�\�W����\�\�5�����\�Z\�$j\�l\���ZK\�aPo<��g��\0K�\�f�&3��46��{96y����\�>��2\�`��y\�\�G8l\'��2\Z�ZN�\�\�|~:@N3X\�\�l:�\��\ras,\�\�:B\0�\�y7\�2�v\�zx�Q�8,2���0��t�E�1\�S̣sl�\�u\�J\�`��q(6���\n�:\�\�K�Х�\�(\0줳|2�x\���\�PF��G\"��\�:MA\�	�\�Aw�\0�\'-\�DF�!�B\�G\'j��t�\�\�\�4MFn�3uDO:U޸hE\�o�Щzb�k\�s�h�\��\�G\�\Z�t�\�\�nB�\��Z1�l&\�ᾝx9\Z\��\�\�\�&b:/�\��\�[̃kt�\�C7(_�\�M^ԙ��gV�\�\r\�`!ݢx\�\�\�Bp^!׍]RL�X��t�����\�\�2gҲ�\�WW\�M�bݧ�\�w~�\�\�a�ޭC�V�����\�\����/K\�>+�������4\\\�S|A\�ž�F\Z.�[h�\�\�\�p�\\\�\�b{QH\�\�\nQJ\�\�JQC\�\�jPC\�\�jPJ\�\�JQH\�\�\n����\�E.\r\�\�\Z.�i�\�F|A\�ž��4\\\�S��\�bk������R\Z.�i�\�B̡\�bs0���M\�D\Z.6#h�\��\�b�Г���DG\Z.\�-h�XD\�p����k�\�Iõv\�@õ6\0XEõV�Gõ\��Jõ�x��k=�7\r\�\�\r�\r\r\�j�\�\�J7���G%�\�ݵ\�U\�u\�ڻ\�\�QOOy\�/K�9�?\�Im\��\�K�z��MBZ�\Z�Ҳ\�\�N���\�\�\��\�\��\�N-}�\�\�R;�\�~\�\n�\����;���8,�zٟ\�\"u}��zI\�aP#\��A��>ʩ�pX���#�.\��5\�FkM=�t�nX�Z\�0O5P�����j��2~�C�\�h���UE�rp\�l\n�\�\�i9;@\�f\�\'(ۺ�\�R���\�	ѓ�\�ၦ<�R��8\"�rf\�Ac\�\�P�8��Rm�	�뾑R\��1\�)TFh/\�\r\n�Ǽ@��\�~}�\"��c�R��+\�\�DCqLG\n���\�d\�c|Ք\�\�\�p�A���ڇZ_Q��\�0?\�Oa�\�q�S���\�\\�KY^\�q\�e}s8\�e_Q�d׆��j\nG������	�(\�;>8T�bʑ�-��8�7�b,ĉ\�R�\�ap�&R��8э\�(8Z\�\�F�(��\"|}\�\'�)Bi(N�!%\�m\�k��|��M�\0\�\�\��\0�q�\�i����z�i�\�q�?m�,\\b2m\��)�i�e!p	\�\Z\�-�J�\�v\��5.��6Ké�\�^Չp�\��W7�ʳ��\ZW�J[\��\�4��Ӳ���\�)�F���\�\\SE\r\�\�\��\�\�p���}�8���\�\�ap��\�h��8�t\�\��\�\0\�&gr3\�2���v�gZL{��Զ��(\�-�=�K���X�3F[|������3���v\rךB;T^��XB\�\r�kŕ\�Kp6�\�\�\�b\�i��q6M\�i�M\�b�V\�r\�MqVY�\��p���\\\�n0�v�B�ZB5�6gUJ���{�+�\�9�K�u�\���\�\�Ź��6\�\�B���\�\\\"\�RO��^��E\��\�\�J5�\���\�R�qnw\�J\�a\�kZ\���\'�����r=8�TZ�8Z�i�T�O�\ZZf�|F\�Դ�y-�eF��A:-�\�ח��\�z\�2}q~\�ݴ\�n�ET\�\"����)�\�\�0~�����H\�\Z��Q*�H@���5���DZc%\�f -�\�a%�\�@\�MX>�0\�Q�i��0\�Q*��\n㨙�B*\�*��\�\'i��8\�Y-\�\�Q��2Pwm�T.㨶T\�\���E\�v�8\�[I\�Pݩ\�r�6Q��T\�e�ާjkQ?��\�(�����G�x�P�{a\�\ZOŶxPO��\�/`\�\ZI\�F��\"�Q�0j\r�Z�\"Qo�V\'�\�ZP\�T�\r�Z��TA4\Z`��	�Z7Q�qh�\�<��\�\�T)/\r2�\n\��8�%U\Z��i��\��8.�\n\�j�\ZI��`\�\�@�F��|;�Ε0j\�Fuv�\�`Q��0j=HuBÅn�2\�0j�R���h��Tf�Z�S��h\����\�2����FI�*K`\��\'UIB#-�\"[a^BE��*�H\'G\�CE*\�h\�T$\�Q�H:\Z/:�jl�qD\�!��� H�\"]`�h\0IA0�\�P����T#\'A�H5��8,��j$\"H2�Fw?��jd\"XZ�R��\r���S�\�V�qT\�x�j�C�x\�Q�\�/�\�%�S�u^Q�j*�\�[B%�;!��Q	�\rp�;�\�4W�f*�큫�o��\�dI*�\nWˠ�$\�,�1\Z.6�j\�B�\�\��d�\�STcO,\�O5j����S��P\"�jT���+?\�Ȃ\Z�T��;\\�O\�(��\"}�H\�\�:�WQ��P\�T\�\�0�J\�<��G��-U�\��H���ʷ�P�sU\��\\\�\�\"�R\�J��2\�c\�\��\0��<R�\�(�@\�ߨ·(\�\�\0\���\�\�΁Pn*��h%\Z�I�\�8X��T\�MX!zUZy1+a=U\�\rK�/�Jy�\�L!#R�\���\�=*�^s8P\�5T*p,�N��\'\�i�\�ʨV:�\�YAŖ���\\�9[၅.\�A\�=\�{���\��\�\\N\�>n��\�T��3,�B\�ʟ	�D�W\r�K�\�2�\��N\�\�͛�^�\�[K����Ck13To�6h��\���\��-��7�-�.���z�$\�\n��Mn��%��g\�P��h��[a�dZd\�\�L\�ǴH2l4����4\�a	�2	��K�T�x14\�\�\�~Ze.\�\�[M\�M��\�W\�2�}�Y\�&Zg\�cQ.\��bZgS,l��O��\0�:�w9-��\0�\�J�%�!�w\�G�TQ��XBkm\Zq.~\�;Z�$B���Ŋ���(׽QF�U�}�h5�\�\�B ���\ZZ�����\��\�hp\���^ͽ%%@\�	[]0dq9mH�0�\�e�~�\�=����x⌧]*�灋`�KF���]\�C�ɴO�\�m]�\�\'\�g2DJ���\��h�Lm��\�\�^�ux	�j}\�״\�x�5*@\�m��\�!P�\�ê]�]`K���\�&&E\"�bnK���Ԥ@�{�(DU��� Z\��ڗ~\nQu/�\�SAA\�3��[Z��<��|d\�{\�)HE�׫�\�oZ��ѿ�҇:	�殱�.�W%\�)\�\r$Q(���\�\�|\��q#�����um�G�\0����\�x{�\�QO��\�?���\�;�(Z\�O]J˨��.\�D\�&\ZA�)ڈ]M#\�V\�B#��4�j�z�D#�&A;\�U4��*\Z���FP\�\n-]��Fl�\Z�j��F��mm�f\�h�t�\\F�ʇAs��\�h�\�\�C{.�\�@+.�x\�4\Z 0\�g���F�\�\r\�h�\Z����p���4\�ev��o�:\�?\0�s\�J\Zu�\�28P\�o*i\�A\�S!p���h�\�7\�ñ\"2h�\�\�H8\�]\�\�8���p��,\Zg�\�뿇\�\�\�W���q���X�E\�f\Z�؜	�VM\�\�\�\�\�.�\�Ѩ��\\\�;��ƏJ\�y\�F�2i� �\�*1����Iɣ�奄�ݢ\�+\�Z\�\�0ѥ%�8,i]hC��<C�\�e���8.�\�\\�H\�á0N\���.�{�\�\�̧\�?\�̢�\�O�\��t���I=@;�\Z\�ܢ�7j\�\�Q0\�\�;�3:\�g�0\�\�b?ſ���h7���Q6����Kͧ#\�\��h���+\�\\`\��0\r�0e75�{J�\���]ZC-\�,\�\�-Rs��\�\�0�\�sǼ�\�\��ywx`Ux�\�j�$�_8\",(�p�D�P&r\�{e�\�A�0�\Z<o\�7opKx�N\��S���Vjv�\��\�\�������\�l?m\�Ϟ\�\�\�>1��}p��8�A\�m10\�\�~t\�w�\�w����\��\�\�Wr\�h���W��!����߽�-@E\�\��ݠ�^�5\��茏�TE\�x�{S��\�v߳��\�R\�F�ܲ��g\�\�CS�\�zyn�_�����f�e�sCz\\\�\�a�n0|\��9��X�\��\�\�-,��)-ܛ�e\���Y�t\�\����C|\\\���\\昑PI�\0\0\0\0IEND�B`�');
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
