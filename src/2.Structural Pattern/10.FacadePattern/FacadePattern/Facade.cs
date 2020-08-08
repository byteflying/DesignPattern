using System;

namespace FacadePattern {

    public class Facade {

        private Haikwan _haikwan = null;
        private Decrypt _decrypt = null;
        private TaxProof _taxProof = null;
        private FileStore _fileStore = null;

        public Facade() {
            _haikwan = new Haikwan();
            _decrypt = new Decrypt();
            _taxProof = new TaxProof();
            _fileStore = new FileStore();
        }

        public void Handle(Uri uri) {
            var ciphertext = _haikwan.Apply(uri);
            var plaintext = _decrypt.Decipher(ciphertext);
            _taxProof.Deserialize(plaintext);
            _fileStore.Store(_taxProof);
        }

    }

}