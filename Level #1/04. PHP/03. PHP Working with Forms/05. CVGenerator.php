<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8" />
        <title>CV Generator</title>
        <style>
			form {
				width: 600px;
				padding: 10px;
			}
			fieldset {
				margin-bottom: 10px;
			}
			tr, th, td {
				border: 1px solid black;
			}
        </style>
    </head>
    <body>
        <form method="post" action="#">
            <fieldset>
                <legend>Personal Information</legend>
                <input type="text" name="fName" placeholder="First Name" required="required"/><br />
                <input type="text" name="lName" placeholder="Last Name" required="required"/><br />
                <input type="email" name="email" placeholder="Email" required="required"/><br />
                <input type="tel" name="phone" placeholder="Phone Number" required="required"/><br />
                <label for="female">Female</label>
                <input type="radio" name="gender" id="female" value="Female"/>
                <label for="male">Male</label>
                <input type="radio" name="gender" id="male" value="Male"/><br />
                <label for="birthday">Birthday</label><br />
                <input type="date" name="birthday" id="birthday" required="required"/><br />
                <label for="nationality">Nationality</label><br />
                <select name="nationality">
                     	<option value="afghan">Afghan</option>
						<option value="albanian">Albanian</option>
						<option value="algerian">Algerian</option>
						<option value="american">American</option>
						<option value="andorran">Andorran</option>
						<option value="angolan">Angolan</option>
						<option value="antiguans">Antiguans</option>
						<option value="argentinean">Argentinean</option>
						<option value="armenian">Armenian</option>
						<option value="australian">Australian</option>
						<option value="austrian">Austrian</option>
						<option value="azerbaijani">Azerbaijani</option>
						<option value="bahamian">Bahamian</option>
						<option value="bahraini">Bahraini</option>
						<option value="bangladeshi">Bangladeshi</option>
						<option value="barbadian">Barbadian</option>
						<option value="barbudans">Barbudans</option>
						<option value="batswana">Batswana</option>
						<option value="belarusian">Belarusian</option>
						<option value="belgian">Belgian</option>
						<option value="belizean">Belizean</option>
						<option value="beninese">Beninese</option>
						<option value="bhutanese">Bhutanese</option>
						<option value="bolivian">Bolivian</option>
						<option value="bosnian">Bosnian</option>
						<option value="brazilian">Brazilian</option>
						<option value="british">British</option>
						<option value="bruneian">Bruneian</option>
						<option value="bulgarian" selected="selected">Bulgarian</option>
						<option value="burkinabe">Burkinabe</option>
						<option value="burmese">Burmese</option>
						<option value="burundian">Burundian</option>
						<option value="cambodian">Cambodian</option>
						<option value="cameroonian">Cameroonian</option>
						<option value="canadian">Canadian</option>
						<option value="cape verdean">Cape Verdean</option>
						<option value="central african">Central African</option>
						<option value="chadian">Chadian</option>
						<option value="chilean">Chilean</option>
						<option value="chinese">Chinese</option>
						<option value="colombian">Colombian</option>
						<option value="comoran">Comoran</option>
						<option value="congolese">Congolese</option>
						<option value="costa rican">Costa Rican</option>
						<option value="croatian">Croatian</option>
						<option value="cuban">Cuban</option>
						<option value="cypriot">Cypriot</option>
						<option value="czech">Czech</option>
						<option value="danish">Danish</option>
						<option value="djibouti">Djibouti</option>
						<option value="dominican">Dominican</option>
						<option value="dutch">Dutch</option>
						<option value="east timorese">East Timorese</option>
						<option value="ecuadorean">Ecuadorean</option>
						<option value="egyptian">Egyptian</option>
						<option value="emirian">Emirian</option>
						<option value="equatorial guinean">Equatorial Guinean</option>
						<option value="eritrean">Eritrean</option>
						<option value="estonian">Estonian</option>
						<option value="ethiopian">Ethiopian</option>
						<option value="fijian">Fijian</option>
						<option value="filipino">Filipino</option>
						<option value="finnish">Finnish</option>
						<option value="french">French</option>
						<option value="gabonese">Gabonese</option>
						<option value="gambian">Gambian</option>
						<option value="georgian">Georgian</option>
						<option value="german">German</option>
						<option value="ghanaian">Ghanaian</option>
						<option value="greek">Greek</option>
						<option value="grenadian">Grenadian</option>
						<option value="guatemalan">Guatemalan</option>
						<option value="guinea-bissauan">Guinea-Bissauan</option>
						<option value="guinean">Guinean</option>
						<option value="guyanese">Guyanese</option>
						<option value="haitian">Haitian</option>
						<option value="herzegovinian">Herzegovinian</option>
						<option value="honduran">Honduran</option>
						<option value="hungarian">Hungarian</option>
						<option value="icelander">Icelander</option>
						<option value="indian">Indian</option>
						<option value="indonesian">Indonesian</option>
						<option value="iranian">Iranian</option>
						<option value="iraqi">Iraqi</option>
						<option value="irish">Irish</option>
						<option value="israeli">Israeli</option>
						<option value="italian">Italian</option>
						<option value="ivorian">Ivorian</option>
						<option value="jamaican">Jamaican</option>
						<option value="japanese">Japanese</option>
						<option value="jordanian">Jordanian</option>
						<option value="kazakhstani">Kazakhstani</option>
						<option value="kenyan">Kenyan</option>
						<option value="kittian and nevisian">Kittian and Nevisian</option>
						<option value="kuwaiti">Kuwaiti</option>
						<option value="kyrgyz">Kyrgyz</option>
						<option value="laotian">Laotian</option>
						<option value="latvian">Latvian</option>
						<option value="lebanese">Lebanese</option>
						<option value="liberian">Liberian</option>
						<option value="libyan">Libyan</option>
						<option value="liechtensteiner">Liechtensteiner</option>
						<option value="lithuanian">Lithuanian</option>
						<option value="luxembourger">Luxembourger</option>
						<option value="macedonian">Macedonian</option>
						<option value="malagasy">Malagasy</option>
						<option value="malawian">Malawian</option>
						<option value="malaysian">Malaysian</option>
						<option value="maldivan">Maldivan</option>
						<option value="malian">Malian</option>
						<option value="maltese">Maltese</option>
						<option value="marshallese">Marshallese</option>
						<option value="mauritanian">Mauritanian</option>
						<option value="mauritian">Mauritian</option>
						<option value="mexican">Mexican</option>
						<option value="micronesian">Micronesian</option>
						<option value="moldovan">Moldovan</option>
						<option value="monacan">Monacan</option>
						<option value="mongolian">Mongolian</option>
						<option value="moroccan">Moroccan</option>
						<option value="mosotho">Mosotho</option>
						<option value="motswana">Motswana</option>
						<option value="mozambican">Mozambican</option>
						<option value="namibian">Namibian</option>
						<option value="nauruan">Nauruan</option>
						<option value="nepalese">Nepalese</option>
						<option value="new zealander">New Zealander</option>
						<option value="ni-vanuatu">Ni-Vanuatu</option>
						<option value="nicaraguan">Nicaraguan</option>
						<option value="nigerien">Nigerien</option>
						<option value="north korean">North Korean</option>
						<option value="northern irish">Northern Irish</option>
						<option value="norwegian">Norwegian</option>
						<option value="omani">Omani</option>
						<option value="pakistani">Pakistani</option>
						<option value="palauan">Palauan</option>
						<option value="panamanian">Panamanian</option>
						<option value="papua new guinean">Papua New Guinean</option>
						<option value="paraguayan">Paraguayan</option>
						<option value="peruvian">Peruvian</option>
						<option value="polish">Polish</option>
						<option value="portuguese">Portuguese</option>
						<option value="qatari">Qatari</option>
						<option value="romanian">Romanian</option>
						<option value="russian">Russian</option>
						<option value="rwandan">Rwandan</option>
						<option value="saint lucian">Saint Lucian</option>
						<option value="salvadoran">Salvadoran</option>
						<option value="samoan">Samoan</option>
						<option value="san marinese">San Marinese</option>
						<option value="sao tomean">Sao Tomean</option>
						<option value="saudi">Saudi</option>
						<option value="scottish">Scottish</option>
						<option value="senegalese">Senegalese</option>
						<option value="serbian">Serbian</option>
						<option value="seychellois">Seychellois</option>
						<option value="sierra leonean">Sierra Leonean</option>
						<option value="singaporean">Singaporean</option>
						<option value="slovakian">Slovakian</option>
						<option value="slovenian">Slovenian</option>
						<option value="solomon islander">Solomon Islander</option>
						<option value="somali">Somali</option>
						<option value="south african">South African</option>
						<option value="south korean">South Korean</option>
						<option value="spanish">Spanish</option>
						<option value="sri lankan">Sri Lankan</option>
						<option value="sudanese">Sudanese</option>
						<option value="surinamer">Surinamer</option>
						<option value="swazi">Swazi</option>
						<option value="swedish">Swedish</option>
						<option value="swiss">Swiss</option>
						<option value="syrian">Syrian</option>
						<option value="taiwanese">Taiwanese</option>
						<option value="tajik">Tajik</option>
						<option value="tanzanian">Tanzanian</option>
						<option value="thai">Thai</option>
						<option value="togolese">Togolese</option>
						<option value="tongan">Tongan</option>
						<option value="trinidadian or tobagonian">Trinidadian or Tobagonian</option>
						<option value="tunisian">Tunisian</option>
						<option value="turkish">Turkish</option>
						<option value="tuvaluan">Tuvaluan</option>
						<option value="ugandan">Ugandan</option>
						<option value="ukrainian">Ukrainian</option>
						<option value="uruguayan">Uruguayan</option>
						<option value="uzbekistani">Uzbekistani</option>
						<option value="venezuelan">Venezuelan</option>
						<option value="vietnamese">Vietnamese</option>
						<option value="welsh">Welsh</option>
						<option value="yemenite">Yemenite</option>
						<option value="zambian">Zambian</option>
						<option value="zimbabwean">Zimbabwean</option> 
                </select>
            </fieldset>
            <fieldset>
                <legend>Last Work Position</legend>
                <label for="company">Company Name</label>
                <input type="text" name="company" id="company" required="required"/><br />
                <label for="fromDate">From</label>
                <input type="date" name="fromDate" id="fromDate" required="required"/><br />
                <label for="toDate">To</label>
                <input type="date" name="toDate" id="toDate" required="required"/><br />
            </fieldset>
            <fieldset id="computerSkills">
                <legend>Computer Skills</legend>
                <label for="progLang">Programming Languages</label><br />
                <div id="progLang">
                    <input type="text" name="progLang[]" required="required"/>
                    <select name="progLangLevel[]">
                        <option value="beginner">Beginner</option>
                        <option value="intermediate">Intermediate</option>
                        <option value="advanced">Advanced</option>
                    </select>
                </div>
                <input type="button" value="Remove Language" onclick="removeProgLang()" id="remProgLang" />
                <input type="button" value="Add Language" onclick="addProgLang()" />
            </fieldset>
            <fieldset id="otherSkills">
                <legend>Other Skills</legend>
                <label for="lang">Languages</label><br />
                <div id="lang">
                    <input type="text" name="lang[]" required="required"/>
                    <select name="comprehension[]">
                        <option disabled="disabled" selected="selected">Comprehension</option>
                        <option value="beginner">Beginner</option>
                        <option value="intermediate">Intermediate</option>
                        <option value="advanced">Advanced</option>
                    </select>
                    <select name="reading[]">
                        <option disabled="disabled" selected="selected">Reading</option>
                        <option value="beginner">Beginner</option>
                        <option value="intermediate">Intermediate</option>
                        <option value="advanced">Advanced</option>
                    </select>
                    <select name="writing[]">
                        <option disabled="disabled" selected="selected">Writing</option>
                        <option value="beginner">Beginner</option>
                        <option value="intermediate">Intermediate</option>
                        <option value="advanced">Advanced</option>
                    </select>
                </div>
                <input type="button" value="Remove Language" onclick="removeLang()" id="remLang" />
                <input type="button" value="Add Language" onclick="addLang()" /><br />
                <span for="driverLicense">Driver`s License</span><br />
                <label for="b">B</label>
                <input type="checkbox" name="b" value="B" id="b" />
                <label for="a">A</label>
                <input type="checkbox" name="a" value="A" id="a" />
                <label for="c">C</label>
                <input type="checkbox" name="c" value="C" id="c" />
            </fieldset>
            <input type="submit" value="Generate CV" />
        </form>
        <br />
        
        <?php
        if (isset($_POST)):
                
            $fName = $_POST['fName'];
            $lName = $_POST['lName'];
            $email = $_POST['email'];
            $phone = $_POST['phone'];
            $gender = $_POST['gender'];
            $birthday = $_POST['birthday'];
            $nationality = $_POST['nationality'];
            $company = $_POST['company'];
            $fromDate = $_POST['fromDate'];
            $toDate = $_POST['toDate'];
            $progLangArray = $_POST['progLang'];
            $progLangLevelArray = $_POST['progLangLevel'];
            $langArray = $_POST['lang'];
            $comprehensionArray = $_POST['comprehension'];
            $readingArray = $_POST['reading'];
            $writingArray = $_POST['writing'];
            
            $driverLicenses = array();
            
            if (isset($_POST['a'])) {
                array_push($driverLicenses, 'A');
            }
            if (isset($_POST['b'])) {
                array_push($driverLicenses, 'B');
            }
            if (isset($_POST['c'])) {
                array_push($driverLicenses, 'C');
            }
            
            $driverLicenses = implode(', ', $driverLicenses);
            
            
            ?>
            
            <table>
                <thead>
                    <tr>
                        <th colspan="2">Personal Information</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>First Name</td>
                        <td><?= htmlspecialchars($fName) ?></td>
                    </tr>
                    <tr>
                        <td>Last Name</td>
                        <td><?= htmlspecialchars($lName) ?></td>
                    </tr>
                    <tr>
                        <td>Email</td>
                        <td><?= htmlspecialchars($email) ?></td>
                    </tr>
                    <tr>
                        <td>Phone Number</td>
                        <td><?= htmlspecialchars($phone) ?></td>
                    </tr>
                    <tr>
                        <td>Gender</td>
                        <td><?= htmlspecialchars($gender) ?></td>
                    </tr>
                    <tr>
                        <td>Birth Date</td>
                        <td><?= htmlspecialchars($birthday) ?></td>
                    </tr>
                    <tr>
                        <td>Nationality</td>
                        <td><?= htmlspecialchars($nationality) ?></td>
                    </tr>
                </tbody>
            </table>
            <br />
        
            <table>
                <thead>
                    <tr>
                        <th colspan="2">Last Work Position</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Company Name</td>
                        <td><?= htmlspecialchars($company) ?></td>
                    </tr>
                    <tr>
                        <td>From</td>
                        <td><?= htmlspecialchars($fromDate) ?></td>
                    </tr>
                    <tr>
                        <td>To</td>
                        <td><?= htmlspecialchars($toDate) ?></td>
                    </tr>
                </tbody>
            </table>
            <br />
            
            <table>
                <thead>
                    <tr>
                        <th colspan="2">Computer Skills</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Programming Languages</td>
                        <td>
                            <table>
                                <thead>
                                    <tr>
                                        <th>Language</th>
                                        <th>Skill Level</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <?php for ($i=0; $i < count($progLangArray); $i++): ?>
                                    <tr>
                                        <td><?= htmlspecialchars($progLangArray[$i]) ?></td>
                                        <td><?= htmlspecialchars($progLangLevelArray[$i]) ?></td>
                                    </tr>
                                    <?php endfor; ?>
                                </tbody>
                            </table>
                        </td>
                    </tr>
                </tbody>
            </table>
            <br />
            
            <table>
                <thead>
                    <tr>
                        <th colspan="2">Other Skills</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Languages</td>
                        <td>
                            <table>
                                <thead>
                                    <tr>
                                        <th>Language</th>
                                        <th>Comprehension</th>
                                        <th>Reading</th>
                                        <th>Writing</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <?php for ($i=0; $i < count($langArray); $i++): ?>
                                    <tr>
                                        <td><?= htmlspecialchars($langArray[$i]) ?></td>
                                        <td><?= htmlspecialchars($comprehensionArray[$i]) ?></td>
                                        <td><?= htmlspecialchars($readingArray[$i]) ?></td>
                                        <td><?= htmlspecialchars($writingArray[$i]) ?></td>
                                    </tr>
                                    <?php endfor; ?>
                                </tbody>
                            </table>
                        </td>
                        <tr>
                            <td>Driver`s License</td>
                            <td><?= htmlspecialchars($driverLicenses) ?></td>
                        </tr>
                    </tr>
                </tbody>
            </table>
        <?php endif; ?>
        
        <script>
			var progLangId = 0;
			var langId = 0;

			function addProgLang() {
				progLangId++;
				var divToAdd = document.getElementById('progLang').cloneNode(true);
				divToAdd.setAttribute('id', 'progLang' + progLangId);
				var parent = document.getElementById('computerSkills');
				var childBefore = document.getElementById('remProgLang');
				parent.insertBefore(divToAdd, childBefore);
			}

			function removeProgLang() {
				var parent = document.getElementById('computerSkills');
				var divs = parent.getElementsByTagName('div');
				if (divs.length > 1) {
					parent.removeChild(divs[divs.length - 1]);
				}
			}

			function addLang() {
				langId++;
				var divToAdd = document.getElementById('lang').cloneNode(true);
				divToAdd.setAttribute('id', 'lang' + langId);
				var parent = document.getElementById('otherSkills');
				var childBefore = document.getElementById('remLang');
				parent.insertBefore(divToAdd, childBefore);
			}

			function removeLang() {
				var parent = document.getElementById('otherSkills');
				var divs = parent.getElementsByTagName('div');
				if (divs.length > 1) {
					parent.removeChild(divs[divs.length - 1]);
				}
			}
        </script>
    </body>
</html>