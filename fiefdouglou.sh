rm -rf .vs
rm -rf packages
cd fiefdouglou
	cd bin/debug
		rm fiefdouglou.exe
		rm fiefdouglou.exe.config
		rm fiefdouglou.pdb
	cd ../../
	rm -rf obj
	cd Properties
		if test -f Settings.settings; then rm Settings.settings; fi
	cd ../
		if test -f .editorconfig; then rm .editorconfig; fi
		if test -f packages.config; then rm packages.config; fi
		if test -f fiefdouglouDataSet.cs; then rm fiefdouglouDataSet.cs; fi
		if test -f fiefdouglouDataSet.xss; then rm fiefdouglouDataSet.xss; fi
		if test -f fiefdouglouDataSet.xsd; then rm fiefdouglouDataSet.xsd; fi
		if test -f fiefdouglouDataSet.xsc; then rm fiefdouglouDataSet.xsc; fi
cd ../
git status
read -p "petite pause (y/n) : " -n 2 test
echo $test
git add *
read -p "veuillez rentrer un nom de commit : " -n 100 toto
git commit -m "$toto"
git push 2> test.log
cat test.log | grep 'merge_requests' | cut -c11-
rm test.log