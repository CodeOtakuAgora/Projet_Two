rm -rf .vs
rm -rf packages
cd fiefdouglou
rm -rf bin
rm -rf obj
cd Properties
rm Settings.settings
cd ../../
git status
read -p "petite pause (y/n) : " -n 2 test
echo $test
git add *
read -p "veuillez rentrer un nom de commit : " -n 100 toto
git commit -m "$toto"
git push